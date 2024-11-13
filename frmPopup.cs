using PopupMessage.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopupMessage
{
    public partial class frmPopup : Form
    {
        public enum enumAction
        {
            wait,
            start,
            close
        }

        public enum enumType
        {
            green,
            red
        }

        private enumAction Action;

        private int x, y;

        public frmPopup()
        {
            InitializeComponent();
        }

        public void ShowAlert(clsSource item)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;

            string fName;

            for (int i = 1; i < 9; i++)
            {
                fName = $"alert{i.ToString()}";

                frmPopup frm = (frmPopup)Application.OpenForms[fName];

                if (frm == null)
                {
                    this.Name = fName;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);

                    break;
                }
            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;


            var type = item.Event.Contains("похорон") ? enumType.red : enumType.green;

            switch (type)
            {
                case enumType.green:
                    this.pictureBox1.Image = Resources.Success;
                    this.BackColor = Color.YellowGreen;
                    break;
                case enumType.red:
                    this.pictureBox1.Image = Resources.Sad;
                    this.BackColor = Color.DarkRed;
                    break;
                default:
                    break;
            }

            this.lbl_Type.Text = item.Person;
            this.lbl_Message.Text = $", {item.Event}";
            this.lbl_Date.Text = item.On_Date.ToShortDateString();    

            this.Show();

            this.Action = enumAction.start;

            this.Timer.Interval = 1;

            Timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timer.Interval = 1;
            Action = enumAction.close;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            switch (this.Action)
            {
                case enumAction.wait:
                    Timer.Interval = 86400000;  // 24 hours
                    Action = enumAction.close;

                    break;
                case enumAction.start:
                    Timer.Interval = 1;
                    this.Opacity += 0.1;

                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                            Action = enumAction.wait;
                    }

                    break;
                case enumAction.close:
                    Timer.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;

                    if (base.Opacity == 0.0)
                        base.Close();

                    break;
                default:
                    break;
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Timer.Interval = 1;
            Action = enumAction.close;
        }
    }
}
