namespace NetworkComunicationBetweenTwo
{
    partial class ClientForm
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
            this.textBoxClientLog = new System.Windows.Forms.TextBox();
            this.groupBoxSenden = new System.Windows.Forms.GroupBox();
            this.textBoxSenden = new System.Windows.Forms.TextBox();
            this.groupBoxEmpfangen = new System.Windows.Forms.GroupBox();
            this.textBoxEmpfangen = new System.Windows.Forms.TextBox();
            this.buttonSocketStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxSenden.SuspendLayout();
            this.groupBoxEmpfangen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxClientLog
            // 
            this.textBoxClientLog.Location = new System.Drawing.Point(6, 19);
            this.textBoxClientLog.Multiline = true;
            this.textBoxClientLog.Name = "textBoxClientLog";
            this.textBoxClientLog.Size = new System.Drawing.Size(276, 180);
            this.textBoxClientLog.TabIndex = 1;
            // 
            // groupBoxSenden
            // 
            this.groupBoxSenden.Controls.Add(this.textBoxSenden);
            this.groupBoxSenden.Location = new System.Drawing.Point(12, 252);
            this.groupBoxSenden.Name = "groupBoxSenden";
            this.groupBoxSenden.Size = new System.Drawing.Size(288, 205);
            this.groupBoxSenden.TabIndex = 2;
            this.groupBoxSenden.TabStop = false;
            this.groupBoxSenden.Text = "Senden";
            // 
            // textBoxSenden
            // 
            this.textBoxSenden.Location = new System.Drawing.Point(6, 19);
            this.textBoxSenden.Multiline = true;
            this.textBoxSenden.Name = "textBoxSenden";
            this.textBoxSenden.Size = new System.Drawing.Size(276, 148);
            this.textBoxSenden.TabIndex = 1;
            // 
            // groupBoxEmpfangen
            // 
            this.groupBoxEmpfangen.Controls.Add(this.textBoxEmpfangen);
            this.groupBoxEmpfangen.Location = new System.Drawing.Point(306, 252);
            this.groupBoxEmpfangen.Name = "groupBoxEmpfangen";
            this.groupBoxEmpfangen.Size = new System.Drawing.Size(303, 205);
            this.groupBoxEmpfangen.TabIndex = 3;
            this.groupBoxEmpfangen.TabStop = false;
            this.groupBoxEmpfangen.Text = "Empfangen";
            // 
            // textBoxEmpfangen
            // 
            this.textBoxEmpfangen.Location = new System.Drawing.Point(6, 19);
            this.textBoxEmpfangen.Multiline = true;
            this.textBoxEmpfangen.Name = "textBoxEmpfangen";
            this.textBoxEmpfangen.Size = new System.Drawing.Size(291, 180);
            this.textBoxEmpfangen.TabIndex = 0;
            // 
            // buttonSocketStart
            // 
            this.buttonSocketStart.Location = new System.Drawing.Point(12, 12);
            this.buttonSocketStart.Name = "buttonSocketStart";
            this.buttonSocketStart.Size = new System.Drawing.Size(105, 23);
            this.buttonSocketStart.TabIndex = 4;
            this.buttonSocketStart.Text = "Verbindung Testen";
            this.buttonSocketStart.UseVisualStyleBackColor = true;
            this.buttonSocketStart.Click += new System.EventHandler(this.buttonSocketStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxClientLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 205);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(306, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 205);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Befehle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Vorwärts";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSocketStart);
            this.Controls.Add(this.groupBoxEmpfangen);
            this.Controls.Add(this.groupBoxSenden);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.groupBoxSenden.ResumeLayout(false);
            this.groupBoxSenden.PerformLayout();
            this.groupBoxEmpfangen.ResumeLayout(false);
            this.groupBoxEmpfangen.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxClientLog;
        private System.Windows.Forms.GroupBox groupBoxSenden;
        private System.Windows.Forms.GroupBox groupBoxEmpfangen;
        public System.Windows.Forms.TextBox textBoxSenden;
        public System.Windows.Forms.TextBox textBoxEmpfangen;
        private System.Windows.Forms.Button buttonSocketStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}