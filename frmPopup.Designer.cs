namespace PopupMessage
{
    partial class frmPopup
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
            components = new System.ComponentModel.Container();
            lbl_Type = new Label();
            btn_Close = new Button();
            pictureBox1 = new PictureBox();
            lbl_Message = new Label();
            Timer = new System.Windows.Forms.Timer(components);
            lbl_Date = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_Type
            // 
            lbl_Type.AutoSize = true;
            lbl_Type.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Type.Location = new Point(88, 12);
            lbl_Type.Name = "lbl_Type";
            lbl_Type.Size = new Size(70, 19);
            lbl_Type.TabIndex = 0;
            lbl_Type.Text = "Персона";
            // 
            // btn_Close
            // 
            btn_Close.FlatAppearance.BorderSize = 0;
            btn_Close.FlatStyle = FlatStyle.Flat;
            btn_Close.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Close.ForeColor = Color.White;
            btn_Close.Image = Properties.Resources.Cancel;
            btn_Close.Location = new Point(439, 20);
            btn_Close.Name = "btn_Close";
            btn_Close.Size = new Size(47, 49);
            btn_Close.TabIndex = 1;
            btn_Close.UseVisualStyleBackColor = true;
            btn_Close.Click += btn_Close_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Success;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 61);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lbl_Message
            // 
            lbl_Message.AutoSize = true;
            lbl_Message.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Message.Location = new Point(181, 54);
            lbl_Message.Name = "lbl_Message";
            lbl_Message.Size = new Size(50, 19);
            lbl_Message.TabIndex = 3;
            lbl_Message.Text = "Подія";
            // 
            // Timer
            // 
            Timer.Interval = 10;
            Timer.Tick += Timer_Tick;
            // 
            // lbl_Date
            // 
            lbl_Date.AutoSize = true;
            lbl_Date.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Date.Location = new Point(88, 54);
            lbl_Date.Name = "lbl_Date";
            lbl_Date.Size = new Size(50, 19);
            lbl_Date.TabIndex = 4;
            lbl_Date.Text = "Дата";
            // 
            // frmPopup
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.YellowGreen;
            ClientSize = new Size(488, 86);
            Controls.Add(lbl_Date);
            Controls.Add(lbl_Message);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Close);
            Controls.Add(lbl_Type);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPopup";
            Text = "frmGreen";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Type;
        private Button btn_Close;
        private PictureBox pictureBox1;
        private Label lbl_Message;
        internal System.Windows.Forms.Timer Timer;
        private Label lbl_Date;
    }
}