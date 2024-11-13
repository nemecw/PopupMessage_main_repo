namespace PopupMessage
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewDateTimeColumn gridViewDateTimeColumn1 = new Telerik.WinControls.UI.GridViewDateTimeColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn1 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            grid_Main = new Telerik.WinControls.UI.RadGridView();
            groupBox1 = new GroupBox();
            btn_Order = new Button();
            lbl_EventsCount = new Label();
            label3 = new Label();
            lbl_Today = new Label();
            label1 = new Label();
            label2 = new Label();
            txt_Event = new TextBox();
            btn_Add = new Button();
            panel1 = new Panel();
            timerSave = new System.Windows.Forms.Timer(components);
            lbl_Saving = new Label();
            timerAlert = new System.Windows.Forms.Timer(components);
            notifyIcon1 = new NotifyIcon(components);
            ((System.ComponentModel.ISupportInitialize)grid_Main).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grid_Main.MasterTemplate).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // grid_Main
            // 
            grid_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grid_Main.BackColor = Color.Transparent;
            grid_Main.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            grid_Main.ForeColor = SystemColors.ControlText;
            grid_Main.ImeMode = ImeMode.NoControl;
            grid_Main.Location = new Point(4, 51);
            // 
            // 
            // 
            grid_Main.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            grid_Main.MasterTemplate.AllowColumnReorder = false;
            grid_Main.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "id";
            gridViewTextBoxColumn1.HeaderText = "ID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 48;
            gridViewDateTimeColumn1.FieldName = "on_date";
            gridViewDateTimeColumn1.FormatString = "{0:dd.MM.yyyy}";
            gridViewDateTimeColumn1.HeaderText = "Дата";
            gridViewDateTimeColumn1.MaxWidth = 140;
            gridViewDateTimeColumn1.MinWidth = 140;
            gridViewDateTimeColumn1.Name = "on_date";
            gridViewDateTimeColumn1.TextAlignment = ContentAlignment.TopCenter;
            gridViewDateTimeColumn1.Width = 140;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Person";
            gridViewTextBoxColumn2.HeaderText = "Персона";
            gridViewTextBoxColumn2.MaxLength = 100;
            gridViewTextBoxColumn2.MinWidth = 180;
            gridViewTextBoxColumn2.Name = "Person";
            gridViewTextBoxColumn2.TextAlignment = ContentAlignment.TopLeft;
            gridViewTextBoxColumn2.Width = 228;
            gridViewComboBoxColumn1.FieldName = "Event";
            gridViewComboBoxColumn1.HeaderText = "Подія";
            gridViewComboBoxColumn1.MinWidth = 200;
            gridViewComboBoxColumn1.Name = "Event";
            gridViewComboBoxColumn1.TextAlignment = ContentAlignment.TopCenter;
            gridViewComboBoxColumn1.Width = 217;
            gridViewTextBoxColumn3.FieldName = "Comment";
            gridViewTextBoxColumn3.HeaderText = "Коментар";
            gridViewTextBoxColumn3.MinWidth = 150;
            gridViewTextBoxColumn3.Name = "Comment";
            gridViewTextBoxColumn3.TextAlignment = ContentAlignment.TopLeft;
            gridViewTextBoxColumn3.Width = 187;
            gridViewTextBoxColumn4.FieldName = "Sort";
            gridViewTextBoxColumn4.HeaderText = "Sort";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "Sort";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.TextAlignment = ContentAlignment.TopCenter;
            gridViewTextBoxColumn4.Width = 29;
            grid_Main.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] { gridViewTextBoxColumn1, gridViewDateTimeColumn1, gridViewTextBoxColumn2, gridViewComboBoxColumn1, gridViewTextBoxColumn3, gridViewTextBoxColumn4 });
            grid_Main.MasterTemplate.EnableGrouping = false;
            grid_Main.MasterTemplate.ShowRowHeaderColumn = false;
            grid_Main.MasterTemplate.ViewDefinition = tableViewDefinition1;
            grid_Main.Name = "grid_Main";
            grid_Main.RightToLeft = RightToLeft.No;
            grid_Main.ShowGroupPanel = false;
            grid_Main.Size = new Size(770, 352);
            grid_Main.TabIndex = 6;
            grid_Main.CellFormatting += grid_Main_CellFormatting;
            grid_Main.CellEditorInitialized += grid_Main_CellEditorInitialized;
            grid_Main.DataBindingComplete += grid_Main_DataBindingComplete;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btn_Order);
            groupBox1.Controls.Add(lbl_EventsCount);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbl_Today);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(7, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(767, 44);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            // 
            // btn_Order
            // 
            btn_Order.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_Order.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Order.Location = new Point(512, 8);
            btn_Order.Name = "btn_Order";
            btn_Order.Size = new Size(249, 36);
            btn_Order.TabIndex = 12;
            btn_Order.Text = "Сортування за замовчуванням";
            btn_Order.UseVisualStyleBackColor = true;
            btn_Order.Click += btn_Order_Click;
            // 
            // lbl_EventsCount
            // 
            lbl_EventsCount.AutoSize = true;
            lbl_EventsCount.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_EventsCount.ForeColor = Color.Red;
            lbl_EventsCount.Location = new Point(372, 16);
            lbl_EventsCount.Name = "lbl_EventsCount";
            lbl_EventsCount.Size = new Size(39, 19);
            lbl_EventsCount.TabIndex = 3;
            lbl_EventsCount.Text = "___";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(251, 16);
            label3.Name = "label3";
            label3.Size = new Size(119, 19);
            label3.TabIndex = 2;
            label3.Text = "Іменинників:";
            // 
            // lbl_Today
            // 
            lbl_Today.AutoSize = true;
            lbl_Today.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Today.ForeColor = Color.Red;
            lbl_Today.Location = new Point(114, 16);
            lbl_Today.Name = "lbl_Today";
            lbl_Today.Size = new Size(39, 19);
            lbl_Today.TabIndex = 1;
            lbl_Today.Text = "___";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 16);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 0;
            label1.Text = "Сьогодні:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 16);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 9;
            label2.Text = "Нова подія";
            // 
            // txt_Event
            // 
            txt_Event.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Event.Location = new Point(107, 11);
            txt_Event.Name = "txt_Event";
            txt_Event.Size = new Size(261, 26);
            txt_Event.TabIndex = 10;
            // 
            // btn_Add
            // 
            btn_Add.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Add.Location = new Point(387, 6);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(84, 36);
            btn_Add.TabIndex = 11;
            btn_Add.Text = "Додати";
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btn_Add);
            panel1.Controls.Add(txt_Event);
            panel1.Location = new Point(5, 413);
            panel1.Name = "panel1";
            panel1.Size = new Size(478, 49);
            panel1.TabIndex = 12;
            // 
            // timerSave
            // 
            timerSave.Interval = 600000;
            timerSave.Tick += timerSave_Tick;
            // 
            // lbl_Saving
            // 
            lbl_Saving.AutoSize = true;
            lbl_Saving.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Saving.ForeColor = Color.Red;
            lbl_Saving.Location = new Point(505, 429);
            lbl_Saving.Name = "lbl_Saving";
            lbl_Saving.Size = new Size(124, 19);
            lbl_Saving.TabIndex = 13;
            lbl_Saving.Text = "Збереження..";
            lbl_Saving.Visible = false;
            // 
            // timerAlert
            // 
            timerAlert.Enabled = true;
            timerAlert.Interval = 10000;
            timerAlert.Tick += timerAlert_Tick;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Події";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 471);
            Controls.Add(lbl_Saving);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(grid_Main);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(760, 400);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Події";
            FormClosing += frmMain_FormClosing;
            Load += frmMain_Load;
            Resize += frmMain_Resize;
            ((System.ComponentModel.ISupportInitialize)grid_Main.MasterTemplate).EndInit();
            ((System.ComponentModel.ISupportInitialize)grid_Main).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Telerik.WinControls.UI.RadGridView grid_Main;
        private GroupBox groupBox1;
        private Label lbl_EventsCount;
        private Label label3;
        private Label lbl_Today;
        private Label label1;
        private Label label2;
        private TextBox txt_Event;
        private Button btn_Add;
        private Button btn_Order;
        private Panel panel1;
        private System.Windows.Forms.Timer timerSave;
        private Label lbl_Saving;
        private System.Windows.Forms.Timer timerAlert;
        private NotifyIcon notifyIcon1;
    }
}
