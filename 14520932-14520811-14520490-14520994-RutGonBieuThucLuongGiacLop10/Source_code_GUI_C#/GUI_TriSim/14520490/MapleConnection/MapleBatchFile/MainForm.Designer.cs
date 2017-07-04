namespace MapleBatchFile
{
    partial class MainForm
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
            this.formSkin1 = new FlatUI.FormSkin();
            this.btnHelp = new FlatUI.FlatButton();
            this.inputTextBox = new FlatUI.FlatTextBox();
            this.btnSolve = new FlatUI.FlatButton();
            this.flatClose1 = new FlatUI.FlatClose();
            this.tbCmapleDir = new FlatUI.FlatTextBox();
            this.btnLoadCmaple = new FlatUI.FlatButton();
            this.tbDK = new FlatUI.FlatTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAbout = new FlatUI.FlatButton();
            this.formSkin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.formSkin1.Controls.Add(this.btnAbout);
            this.formSkin1.Controls.Add(this.btnHelp);
            this.formSkin1.Controls.Add(this.inputTextBox);
            this.formSkin1.Controls.Add(this.btnSolve);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Controls.Add(this.tbCmapleDir);
            this.formSkin1.Controls.Add(this.btnLoadCmaple);
            this.formSkin1.Controls.Add(this.tbDK);
            this.formSkin1.Controls.Add(this.label2);
            this.formSkin1.Controls.Add(this.label1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(838, 251);
            this.formSkin1.TabIndex = 2;
            this.formSkin1.Text = "TRIGONOMETRIC SIMPLIFICATION";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(732, 17);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Rounded = false;
            this.btnHelp.Size = new System.Drawing.Size(64, 18);
            this.btnHelp.TabIndex = 20;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.BackColor = System.Drawing.Color.Transparent;
            this.inputTextBox.FocusOnHover = false;
            this.inputTextBox.Location = new System.Drawing.Point(12, 129);
            this.inputTextBox.MaxLength = 32767;
            this.inputTextBox.Multiline = false;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ReadOnly = false;
            this.inputTextBox.Size = new System.Drawing.Size(615, 34);
            this.inputTextBox.TabIndex = 18;
            this.inputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputTextBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.inputTextBox.UseSystemPasswordChar = false;
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.Transparent;
            this.btnSolve.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnSolve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSolve.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSolve.Location = new System.Drawing.Point(633, 129);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Rounded = false;
            this.btnSolve.Size = new System.Drawing.Size(194, 92);
            this.btnSolve.TabIndex = 17;
            this.btnSolve.Text = "Thực hiện rút gọn";
            this.btnSolve.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(804, 16);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 16;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.White;
            // 
            // tbCmapleDir
            // 
            this.tbCmapleDir.BackColor = System.Drawing.Color.Transparent;
            this.tbCmapleDir.FocusOnHover = false;
            this.tbCmapleDir.Location = new System.Drawing.Point(12, 71);
            this.tbCmapleDir.MaxLength = 32767;
            this.tbCmapleDir.Multiline = false;
            this.tbCmapleDir.Name = "tbCmapleDir";
            this.tbCmapleDir.ReadOnly = true;
            this.tbCmapleDir.Size = new System.Drawing.Size(615, 34);
            this.tbCmapleDir.TabIndex = 15;
            this.tbCmapleDir.Text = "Choose cmaple.exe first...";
            this.tbCmapleDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbCmapleDir.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbCmapleDir.UseSystemPasswordChar = false;
            // 
            // btnLoadCmaple
            // 
            this.btnLoadCmaple.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadCmaple.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnLoadCmaple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadCmaple.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLoadCmaple.Location = new System.Drawing.Point(633, 71);
            this.btnLoadCmaple.Name = "btnLoadCmaple";
            this.btnLoadCmaple.Rounded = false;
            this.btnLoadCmaple.Size = new System.Drawing.Size(194, 32);
            this.btnLoadCmaple.TabIndex = 14;
            this.btnLoadCmaple.Text = "Chọn cmaple.exe";
            this.btnLoadCmaple.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnLoadCmaple.Click += new System.EventHandler(this.btnLoadCmaple_Click);
            // 
            // tbDK
            // 
            this.tbDK.BackColor = System.Drawing.Color.Transparent;
            this.tbDK.FocusOnHover = false;
            this.tbDK.Location = new System.Drawing.Point(13, 187);
            this.tbDK.MaxLength = 32767;
            this.tbDK.Multiline = false;
            this.tbDK.Name = "tbDK";
            this.tbDK.ReadOnly = false;
            this.tbDK.Size = new System.Drawing.Size(614, 34);
            this.tbDK.TabIndex = 22;
            this.tbDK.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbDK.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbDK.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(12, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Điều kiện bổ sung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(9, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Biểu thức lượng giác";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.Location = new System.Drawing.Point(662, 17);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Rounded = false;
            this.btnAbout.Size = new System.Drawing.Size(64, 18);
            this.btnAbout.TabIndex = 20;
            this.btnAbout.Text = "About";
            this.btnAbout.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 251);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatButton btnHelp;
        private FlatUI.FlatTextBox inputTextBox;
        private FlatUI.FlatButton btnSolve;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatTextBox tbCmapleDir;
        private FlatUI.FlatButton btnLoadCmaple;
        private FlatUI.FlatTextBox tbDK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FlatUI.FlatButton btnAbout;
    }
}