using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PopupMessage.Class_frmMain;

namespace PopupMessage
{
    public partial class frmSettings : Form
    {
        public string Data_Path => txt_Path.Text;

        string default_path = String.Empty;

        public bool isClosedWithButton = false;

        public frmSettings(string path)
        {
            InitializeComponent();

            default_path = path;
        }

        private void btn_OpenFileLocation_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string Error = String.Empty;

                if (!File.Exists($"{folderBrowserDialog1.SelectedPath}\\{DefaultSettings.const_SettingsFile}"))
                    Error = $"У вказаній папці відсутній файл з налаштуваннями ({DefaultSettings.const_SettingsFile})";

                if (!File.Exists($"{folderBrowserDialog1.SelectedPath}\\{DefaultSettings.const_DataFile}"))
                    Error += $"\n\nУ вказаній папці відсутній файл з даними ({DefaultSettings.const_DataFile})";

                if (!File.Exists($"{folderBrowserDialog1.SelectedPath}\\{DefaultSettings.const_EventFile}"))
                    Error += $"\n\nУ вказаній папці відсутній файл з типізацією подій ({DefaultSettings.const_EventFile})";

                if (Error.IsFull())
                { 
                    MessageBox.Show(Error, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                txt_Path.Text = folderBrowserDialog1.SelectedPath;
            }
            
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            isClosedWithButton = true;

            Close();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            txt_Path.Text = default_path;
        }
    }
}
