namespace MapleBatchFile
{
    partial class FormAbout
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
            this.btOk = new FlatUI.FlatButton();
            this.lbAbout = new FlatUI.FlatLabel();
            this.formSkin1 = new FlatUI.FormSkin();
            this.formSkin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOk
            // 
            this.btOk.BackColor = System.Drawing.Color.Transparent;
            this.btOk.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOk.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btOk.Location = new System.Drawing.Point(114, 198);
            this.btOk.Name = "btOk";
            this.btOk.Rounded = false;
            this.btOk.Size = new System.Drawing.Size(106, 32);
            this.btOk.TabIndex = 2;
            this.btOk.Text = "OK";
            this.btOk.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // lbAbout
            // 
            this.lbAbout.AutoSize = true;
            this.lbAbout.BackColor = System.Drawing.Color.Transparent;
            this.lbAbout.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAbout.ForeColor = System.Drawing.Color.White;
            this.lbAbout.Location = new System.Drawing.Point(19, 77);
            this.lbAbout.Name = "lbAbout";
            this.lbAbout.Size = new System.Drawing.Size(94, 25);
            this.lbAbout.TabIndex = 1;
            this.lbAbout.Text = "flatLabel1";
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.formSkin1.Controls.Add(this.btOk);
            this.formSkin1.Controls.Add(this.lbAbout);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(321, 242);
            this.formSkin1.TabIndex = 2;
            this.formSkin1.Text = "About";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 242);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAbout";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FlatButton btOk;
        private FlatUI.FlatLabel lbAbout;
        private FlatUI.FormSkin formSkin1;
    }
}