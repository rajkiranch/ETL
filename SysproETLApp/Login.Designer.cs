namespace SysproETLApp
{
    partial class Login
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
            this.btnTest = new System.Windows.Forms.Button();
            this.btnTestFileConfig = new System.Windows.Forms.Button();
            this.btnServiceConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(61, 43);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(181, 23);
            this.btnTest.TabIndex = 0;
            this.btnTest.Text = "Test Exception";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnTestFileConfig
            // 
            this.btnTestFileConfig.Location = new System.Drawing.Point(61, 84);
            this.btnTestFileConfig.Name = "btnTestFileConfig";
            this.btnTestFileConfig.Size = new System.Drawing.Size(181, 23);
            this.btnTestFileConfig.TabIndex = 1;
            this.btnTestFileConfig.Text = "Test File Configuration";
            this.btnTestFileConfig.UseVisualStyleBackColor = true;
            this.btnTestFileConfig.Click += new System.EventHandler(this.btnTestFileConfig_Click);
            // 
            // btnServiceConfig
            // 
            this.btnServiceConfig.Location = new System.Drawing.Point(61, 125);
            this.btnServiceConfig.Name = "btnServiceConfig";
            this.btnServiceConfig.Size = new System.Drawing.Size(181, 23);
            this.btnServiceConfig.TabIndex = 2;
            this.btnServiceConfig.Text = "Test Service Configuration";
            this.btnServiceConfig.UseVisualStyleBackColor = true;
            this.btnServiceConfig.Click += new System.EventHandler(this.btnServiceConfig_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnServiceConfig);
            this.Controls.Add(this.btnTestFileConfig);
            this.Controls.Add(this.btnTest);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Syspro ETL";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnTestFileConfig;
        private System.Windows.Forms.Button btnServiceConfig;
    }
}

