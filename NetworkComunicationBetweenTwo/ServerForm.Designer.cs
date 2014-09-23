namespace NetworkComunicationBetweenTwo
{
    partial class ServerForm
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
            this.textBoxServerLog = new System.Windows.Forms.TextBox();
            this.buttonServerStarten = new System.Windows.Forms.Button();
            this.buttonServerSimpleStart = new System.Windows.Forms.Button();
            this.buttonSocketStart = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBoxServerLog
            // 
            this.textBoxServerLog.Location = new System.Drawing.Point(12, 12);
            this.textBoxServerLog.Multiline = true;
            this.textBoxServerLog.Name = "textBoxServerLog";
            this.textBoxServerLog.Size = new System.Drawing.Size(458, 327);
            this.textBoxServerLog.TabIndex = 0;
            // 
            // buttonServerStarten
            // 
            this.buttonServerStarten.Location = new System.Drawing.Point(12, 345);
            this.buttonServerStarten.Name = "buttonServerStarten";
            this.buttonServerStarten.Size = new System.Drawing.Size(82, 23);
            this.buttonServerStarten.TabIndex = 1;
            this.buttonServerStarten.Text = "Server starten";
            this.buttonServerStarten.UseVisualStyleBackColor = true;
            this.buttonServerStarten.Click += new System.EventHandler(this.buttonServerStarten_Click);
            // 
            // buttonServerSimpleStart
            // 
            this.buttonServerSimpleStart.Location = new System.Drawing.Point(135, 345);
            this.buttonServerSimpleStart.Name = "buttonServerSimpleStart";
            this.buttonServerSimpleStart.Size = new System.Drawing.Size(108, 23);
            this.buttonServerSimpleStart.TabIndex = 2;
            this.buttonServerSimpleStart.Text = "TCP Server starten";
            this.buttonServerSimpleStart.UseVisualStyleBackColor = true;
            this.buttonServerSimpleStart.Click += new System.EventHandler(this.buttonServerSimpleStart_Click);
            // 
            // buttonSocketStart
            // 
            this.buttonSocketStart.Location = new System.Drawing.Point(308, 345);
            this.buttonSocketStart.Name = "buttonSocketStart";
            this.buttonSocketStart.Size = new System.Drawing.Size(120, 23);
            this.buttonSocketStart.TabIndex = 3;
            this.buttonSocketStart.Text = "Socket Server starten";
            this.buttonSocketStart.UseVisualStyleBackColor = true;
            this.buttonSocketStart.Click += new System.EventHandler(this.buttonSocketStart_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialogServer";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 425);
            this.Controls.Add(this.buttonSocketStart);
            this.Controls.Add(this.buttonServerSimpleStart);
            this.Controls.Add(this.buttonServerStarten);
            this.Controls.Add(this.textBoxServerLog);
            this.Name = "ServerForm";
            this.Text = "ServerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxServerLog;
        private System.Windows.Forms.Button buttonServerStarten;
        private System.Windows.Forms.Button buttonServerSimpleStart;
        private System.Windows.Forms.Button buttonSocketStart;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}