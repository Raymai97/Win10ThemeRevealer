namespace Win10ThemeRevealer
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStep1 = new System.Windows.Forms.Label();
            this.btnReveal = new System.Windows.Forms.Button();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.btnTryWindowsColorRevived = new System.Windows.Forms.Button();
            this.lblDoneWithIt = new System.Windows.Forms.Label();
            this.btnRestoreSystemDefault = new System.Windows.Forms.Button();
            this.btnTryWindowsLite = new System.Windows.Forms.Button();
            this.lnkHomepage = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(304, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Try out the hidden themes in Windows 10!";
            // 
            // lblStep1
            // 
            this.lblStep1.AutoSize = true;
            this.lblStep1.Location = new System.Drawing.Point(69, 73);
            this.lblStep1.Margin = new System.Windows.Forms.Padding(3);
            this.lblStep1.Name = "lblStep1";
            this.lblStep1.Size = new System.Drawing.Size(42, 15);
            this.lblStep1.TabIndex = 1;
            this.lblStep1.Text = "Step 1:";
            // 
            // btnReveal
            // 
            this.btnReveal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReveal.Location = new System.Drawing.Point(131, 65);
            this.btnReveal.Name = "btnReveal";
            this.btnReveal.Size = new System.Drawing.Size(200, 30);
            this.btnReveal.TabIndex = 0;
            this.btnReveal.Text = "Reveal!";
            this.btnReveal.UseVisualStyleBackColor = true;
            this.btnReveal.Click += new System.EventHandler(this.btnReveal_Click);
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Location = new System.Drawing.Point(69, 109);
            this.lblStep2.Margin = new System.Windows.Forms.Padding(3);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(42, 15);
            this.lblStep2.TabIndex = 1;
            this.lblStep2.Text = "Step 2:";
            // 
            // btnTryWindowsColorRevived
            // 
            this.btnTryWindowsColorRevived.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTryWindowsColorRevived.Location = new System.Drawing.Point(130, 101);
            this.btnTryWindowsColorRevived.Name = "btnTryWindowsColorRevived";
            this.btnTryWindowsColorRevived.Size = new System.Drawing.Size(200, 30);
            this.btnTryWindowsColorRevived.TabIndex = 1;
            this.btnTryWindowsColorRevived.Text = "Try \"Windows Color Revived\"";
            this.btnTryWindowsColorRevived.UseVisualStyleBackColor = true;
            this.btnTryWindowsColorRevived.Click += new System.EventHandler(this.btnTryWindowsColorRevived_Click);
            // 
            // lblDoneWithIt
            // 
            this.lblDoneWithIt.AutoSize = true;
            this.lblDoneWithIt.Location = new System.Drawing.Point(70, 192);
            this.lblDoneWithIt.Margin = new System.Windows.Forms.Padding(3);
            this.lblDoneWithIt.Name = "lblDoneWithIt";
            this.lblDoneWithIt.Size = new System.Drawing.Size(93, 15);
            this.lblDoneWithIt.TabIndex = 1;
            this.lblDoneWithIt.Text = "I\'m done with it:";
            // 
            // btnRestoreSystemDefault
            // 
            this.btnRestoreSystemDefault.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRestoreSystemDefault.Location = new System.Drawing.Point(73, 218);
            this.btnRestoreSystemDefault.Name = "btnRestoreSystemDefault";
            this.btnRestoreSystemDefault.Size = new System.Drawing.Size(258, 30);
            this.btnRestoreSystemDefault.TabIndex = 3;
            this.btnRestoreSystemDefault.Text = "Restore system default";
            this.btnRestoreSystemDefault.UseVisualStyleBackColor = true;
            this.btnRestoreSystemDefault.Click += new System.EventHandler(this.btnRestoreSystemDefault_Click);
            // 
            // btnTryWindowsLite
            // 
            this.btnTryWindowsLite.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTryWindowsLite.Location = new System.Drawing.Point(130, 137);
            this.btnTryWindowsLite.Name = "btnTryWindowsLite";
            this.btnTryWindowsLite.Size = new System.Drawing.Size(200, 30);
            this.btnTryWindowsLite.TabIndex = 2;
            this.btnTryWindowsLite.Text = "Try \"Windows Lite\"";
            this.btnTryWindowsLite.UseVisualStyleBackColor = true;
            this.btnTryWindowsLite.Click += new System.EventHandler(this.btnTryWindowsLite_Click);
            // 
            // lnkHomepage
            // 
            this.lnkHomepage.AutoSize = true;
            this.lnkHomepage.Location = new System.Drawing.Point(163, 263);
            this.lnkHomepage.Margin = new System.Windows.Forms.Padding(3);
            this.lnkHomepage.Name = "lnkHomepage";
            this.lnkHomepage.Size = new System.Drawing.Size(225, 15);
            this.lnkHomepage.TabIndex = 4;
            this.lnkHomepage.TabStop = true;
            this.lnkHomepage.Text = "raymai97.github.io/Win10ThemeRevealer";
            this.lnkHomepage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHomepage_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 290);
            this.Controls.Add(this.lnkHomepage);
            this.Controls.Add(this.btnRestoreSystemDefault);
            this.Controls.Add(this.lblDoneWithIt);
            this.Controls.Add(this.btnTryWindowsLite);
            this.Controls.Add(this.btnTryWindowsColorRevived);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.btnReveal);
            this.Controls.Add(this.lblStep1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win10 Theme Revealer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStep1;
        private System.Windows.Forms.Button btnReveal;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Button btnTryWindowsColorRevived;
        private System.Windows.Forms.Label lblDoneWithIt;
        private System.Windows.Forms.Button btnRestoreSystemDefault;
        private System.Windows.Forms.Button btnTryWindowsLite;
        private System.Windows.Forms.LinkLabel lnkHomepage;
    }
}

