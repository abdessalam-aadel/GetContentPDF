namespace GetContentPDF
{
    partial class FrmMain
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
            btnLoad = new Button();
            txtBoxPath = new TextBox();
            btnStart = new Button();
            txtBoxPat = new TextBox();
            lblPaterne = new Label();
            GitLink = new Label();
            lblCountPDF = new Label();
            lblAlert = new Label();
            lblDone = new Label();
            picDone = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picDone).BeginInit();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Cursor = Cursors.Hand;
            btnLoad.Location = new Point(516, 20);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(98, 31);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "...";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // txtBoxPath
            // 
            txtBoxPath.Enabled = false;
            txtBoxPath.ForeColor = SystemColors.WindowFrame;
            txtBoxPath.Location = new Point(22, 20);
            txtBoxPath.Name = "txtBoxPath";
            txtBoxPath.Size = new Size(488, 31);
            txtBoxPath.TabIndex = 1;
            txtBoxPath.Text = "Select your folder ...";
            // 
            // btnStart
            // 
            btnStart.Cursor = Cursors.Hand;
            btnStart.Location = new Point(250, 166);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(112, 34);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // txtBoxPat
            // 
            txtBoxPat.Location = new Point(159, 88);
            txtBoxPat.Name = "txtBoxPat";
            txtBoxPat.Size = new Size(351, 31);
            txtBoxPat.TabIndex = 3;
            txtBoxPat.Text = "(?<=(CONTENANCE ADOPTEE  = )).*(?=ca)";
            // 
            // lblPaterne
            // 
            lblPaterne.AutoSize = true;
            lblPaterne.Location = new Point(22, 91);
            lblPaterne.Name = "lblPaterne";
            lblPaterne.Size = new Size(131, 25);
            lblPaterne.TabIndex = 4;
            lblPaterne.Text = "Regex Paterne :";
            // 
            // GitLink
            // 
            GitLink.AutoSize = true;
            GitLink.Cursor = Cursors.Hand;
            GitLink.Font = new Font("Segoe UI", 9F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            GitLink.ForeColor = SystemColors.Highlight;
            GitLink.Location = new Point(272, 203);
            GitLink.Name = "GitLink";
            GitLink.Size = new Size(69, 25);
            GitLink.TabIndex = 5;
            GitLink.Text = "Github.";
            GitLink.Click += GitLink_Click;
            // 
            // lblCountPDF
            // 
            lblCountPDF.AutoSize = true;
            lblCountPDF.ForeColor = Color.Green;
            lblCountPDF.Location = new Point(22, 66);
            lblCountPDF.Name = "lblCountPDF";
            lblCountPDF.Size = new Size(24, 25);
            lblCountPDF.TabIndex = 6;
            lblCountPDF.Text = "...";
            // 
            // lblAlert
            // 
            lblAlert.AutoSize = true;
            lblAlert.ForeColor = Color.Red;
            lblAlert.Location = new Point(22, 127);
            lblAlert.Name = "lblAlert";
            lblAlert.Size = new Size(0, 25);
            lblAlert.TabIndex = 7;
            // 
            // lblDone
            // 
            lblDone.AutoSize = true;
            lblDone.ForeColor = Color.Green;
            lblDone.Location = new Point(22, 180);
            lblDone.Name = "lblDone";
            lblDone.Size = new Size(0, 25);
            lblDone.TabIndex = 8;
            // 
            // picDone
            // 
            picDone.Image = Properties.Resources.Done;
            picDone.Location = new Point(82, 179);
            picDone.Name = "picDone";
            picDone.Size = new Size(31, 34);
            picDone.SizeMode = PictureBoxSizeMode.StretchImage;
            picDone.TabIndex = 9;
            picDone.TabStop = false;
            picDone.Visible = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(623, 237);
            Controls.Add(picDone);
            Controls.Add(lblDone);
            Controls.Add(lblAlert);
            Controls.Add(lblCountPDF);
            Controls.Add(GitLink);
            Controls.Add(lblPaterne);
            Controls.Add(txtBoxPat);
            Controls.Add(btnStart);
            Controls.Add(txtBoxPath);
            Controls.Add(btnLoad);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Get Content PDF";
            ((System.ComponentModel.ISupportInitialize)picDone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoad;
        private TextBox txtBoxPath;
        private Button btnStart;
        private TextBox txtBoxPat;
        private Label lblPaterne;
        private Label GitLink;
        private Label lblCountPDF;
        private Label lblAlert;
        private Label lblDone;
        private PictureBox picDone;
    }
}
