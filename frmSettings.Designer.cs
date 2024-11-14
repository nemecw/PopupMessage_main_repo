namespace PopupMessage
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btn_OpenFileLocation = new Button();
            txt_Path = new TextBox();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            btn_Close = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btn_OpenFileLocation);
            panel1.Controls.Add(txt_Path);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(548, 225);
            panel1.TabIndex = 0;
            // 
            // btn_OpenFileLocation
            // 
            btn_OpenFileLocation.Image = Properties.Resources.OpenFile;
            btn_OpenFileLocation.Location = new Point(497, 4);
            btn_OpenFileLocation.Name = "btn_OpenFileLocation";
            btn_OpenFileLocation.Size = new Size(38, 37);
            btn_OpenFileLocation.TabIndex = 2;
            btn_OpenFileLocation.UseVisualStyleBackColor = true;
            btn_OpenFileLocation.Click += btn_OpenFileLocation_Click;
            // 
            // txt_Path
            // 
            txt_Path.Location = new Point(136, 17);
            txt_Path.Name = "txt_Path";
            txt_Path.ReadOnly = true;
            txt_Path.Size = new Size(355, 23);
            txt_Path.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 18);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "Розташування даних";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_Close
            // 
            btn_Close.Location = new Point(566, 202);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(84, 36);
            btn_Close.TabIndex = 1;
            btn_Close.Text = "Закрити";
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 249);
            Controls.Add(btn_Close);
            Controls.Add(panel1);
            Name = "frmSettings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Налаштування";
            Load += frmSettings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_OpenFileLocation;
        private TextBox txt_Path;
        private Label label1;
        private OpenFileDialog openFileDialog1;
        private Button btn_Close;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}