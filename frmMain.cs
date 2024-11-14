using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;
using Newtonsoft.Json;
using Telerik.WinControls;
using Telerik.WinControls.Data;
using Telerik.WinControls.UI;
using Windows.Storage.Provider;

namespace PopupMessage
{
    using CAT = Class_frmMain;

    public partial class frmMain : Form
    {
        #region Variables 

        CAT CA = new CAT();

        #endregion

        #region Form events

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;

            grid_Main.CurrentRow = null;

            grid_Main.DataBindings.Add(new Binding("DataSource", CA, "Source", false, DataSourceUpdateMode.OnPropertyChanged));
            grid_Main.MasterTemplate.AddNewBoundRowBeforeEdit = true;

            if (!LoadData())
                return;
            
            grid_Main.DataSource = CA.Source;

            grid_Main.CurrentRow = (CA.Source.Count == 0) ? null : grid_Main.Rows[0];

            (grid_Main.Columns["Event"] as GridViewComboBoxColumn).DataSource = CA.EventSource;

            GetInfo();

            timerSave.Enabled = true;
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;

                notifyIcon1.Visible = true;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CA.IsSourceChanged)
            {
                var answer = MessageBox.Show(CAT.SourceIsChanged, this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.No)
                {
                    return;
                }

                CA.SaveData(out string Message);

                if (Message != "ok")
                {
                    MessageBox.Show(Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                    return;
                }

                CA.MoveFilesToDefaultLocation();
            }
        }

        #endregion

        #region Button events

        public void Alert(clsSource item)
        {
            frmPopup frm = new frmPopup();
            frm.ShowAlert(item);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Event.Text.IsFull())
            {
                if (!CA.EventSource.Contains(txt_Event.Text))
                    CA.EventSource.Add(txt_Event.Text);
            }

            txt_Event.Text = String.Empty;
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            //grid_Main.DataSource = null;
            //grid_Main.DataSource = CA.Source;

            this.grid_Main.MasterTemplate.SortDescriptors.Clear();

            this.grid_Main.MasterTemplate.EnableSorting = true;

            SortDescriptor descriptor = new SortDescriptor();
            descriptor.PropertyName = "Sort";
            descriptor.Direction = ListSortDirection.Ascending;
            this.grid_Main.MasterTemplate.SortDescriptors.Add(descriptor);
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            frmSettings form = new frmSettings(CA.path_Default);
            form.ShowDialog();

            if (form.isClosedWithButton)
            {
                if (CA.path_Default != form.Data_Path)
                {
                    CA.SaveNewSettings(form.Data_Path, out string Message);

                    if (Message != "ok")
                    {
                        MessageBox.Show(Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                        CA.ClearSources();

                        timerSave.Enabled = false;

                        return;
                    }

                    timerSave.Enabled = false;

                    LoadData();

                    CA.path_Default = form.Data_Path;

                    timerSave.Enabled = true;
                }
            }
        }

        #endregion

        #region Grid events

        private void grid_Main_DataBindingComplete(object sender, Telerik.WinControls.UI.GridViewBindingCompleteEventArgs e)
        {
            for (int j = 0; j < this.grid_Main.Columns.Count; j++)
            {
                if (this.grid_Main.Columns[j].GetType() == typeof(Telerik.WinControls.UI.GridViewDateTimeColumn))
                {
                    ((GridViewDateTimeColumn)this.grid_Main.Columns[j]).FormatString = "{0:dd/MM/yyyy}";
                    ((GridViewDateTimeColumn)this.grid_Main.Columns[j]).Format = DateTimePickerFormat.Custom;
                    ((GridViewDateTimeColumn)this.grid_Main.Columns[j]).CustomFormat = "dd/MM/yyyy";
                }
            }
        }

        private void grid_Main_CellEditorInitialized(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name == "Event")
            {
                (e.Column as GridViewComboBoxColumn).DataSource = CA.EventSource;
            }
        }

        private void grid_Main_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (CA == null || CA.Source == null || CA.Source.Count == 0) return;

            var item = (e.Row.DataBoundItem as clsSource);

            if (item == null) return;


            e.CellElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local);
            e.CellElement.ResetValue(LightVisualElement.GradientStyleProperty, ValueResetFlags.Local);
            e.CellElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local);

            if (item.On_Date.Day == DateTime.Now.Day && item.On_Date.Month == DateTime.Now.Month)
            {
                e.CellElement.DrawFill = true;
                e.CellElement.GradientStyle = GradientStyles.Solid;
                e.CellElement.BackColor = Color.Coral;
            }

        }

        #endregion

        #region Control events

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;

            this.ShowInTaskbar = true;

            WindowState = FormWindowState.Normal;
        }

        private void timerSave_Tick(object sender, EventArgs e)
        {
            if (CA.IsSourceChanged)
            {
                this.Cursor = Cursors.WaitCursor;

                lbl_Saving.Visible = true;

                CA.SaveData(out string Message);

                lbl_Saving.Visible = false;

                this.Cursor = Cursors.Default;
            }
        }

        private void timerAlert_Tick(object sender, EventArgs e)
        {
            foreach (var item in CA.AlertSource.Where(r => r.isShown == false))
            {
                Alert(item);

                item.isShown = true;
            }
        }

        #endregion

        #region Routines

        private void GetInfo()
        {
            lbl_Today.Text = DateTime.Now.ToShortDateString();

            if (CA.Source.Count != 0)
            {
                var found = CA.Source.Where(r => r.On_Date.Day == DateTime.Now.Day && r.On_Date.Month == DateTime.Now.Month).FirstOrDefault();

                lbl_EventsCount.Text = (found != null) ? CA.Source.Where(r => r.On_Date.Day == DateTime.Now.Day && r.On_Date.Month == DateTime.Now.Month).Count().ToString() : "0";
            }
        }

        private bool LoadData()
        {
            CA.GetSettings(out string Message);

            if (Message != "ok")
            {
                MessageBox.Show(Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            CA.LoadData(out Message);

            return true;
        }

        #endregion
    }
}
