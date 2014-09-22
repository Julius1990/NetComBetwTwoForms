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
            this.buttonClientStarten = new System.Windows.Forms.Button();
            this.textBoxClientLog = new System.Windows.Forms.TextBox();
            this.groupBoxSenden = new System.Windows.Forms.GroupBox();
            this.groupBoxEmpfangen = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSenden = new System.Windows.Forms.TextBox();
            this.textBoxEmpfangen = new System.Windows.Forms.TextBox();
            this.buttonSimpelClientStart = new System.Windows.Forms.Button();
            this.buttonSocketStart = new System.Windows.Forms.Button();
            this.groupBoxSenden.SuspendLayout();
            this.groupBoxEmpfangen.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClientStarten
            // 
            this.buttonClientStarten.Location = new System.Drawing.Point(12, 12);
            this.buttonClientStarten.Name = "buttonClientStarten";
            this.buttonClientStarten.Size = new System.Drawing.Size(76, 23);
            this.buttonClientStarten.TabIndex = 0;
            this.buttonClientStarten.Text = "Client starten";
            this.buttonClientStarten.UseVisualStyleBackColor = true;
            this.buttonClientStarten.Click += new System.EventHandler(this.buttonClientStarten_Click);
            // 
            // textBoxClientLog
            // 
            this.textBoxClientLog.Location = new System.Drawing.Point(12, 41);
            this.textBoxClientLog.Multiline = true;
            this.textBoxClientLog.Name = "textBoxClientLog";
            this.textBoxClientLog.Size = new System.Drawing.Size(288, 439);
            this.textBoxClientLog.TabIndex = 1;
            // 
            // groupBoxSenden
            // 
            this.groupBoxSenden.Controls.Add(this.textBoxSenden);
            this.groupBoxSenden.Controls.Add(this.button1);
            this.groupBoxSenden.Location = new System.Drawing.Point(306, 41);
            this.groupBoxSenden.Name = "groupBoxSenden";
            this.groupBoxSenden.Size = new System.Drawing.Size(303, 205);
            this.groupBoxSenden.TabIndex = 2;
            this.groupBoxSenden.TabStop = false;
            this.groupBoxSenden.Text = "Senden";
            // 
            // groupBoxEmpfangen
            // 
            this.groupBoxEmpfangen.Controls.Add(this.textBoxEmpfangen);
            this.groupBoxEmpfangen.Location = new System.Drawing.Point(306, 252);
            this.groupBoxEmpfangen.Name = "groupBoxEmpfangen";
            this.groupBoxEmpfangen.Size = new System.Drawing.Size(303, 228);
            this.groupBoxEmpfangen.TabIndex = 3;
            this.groupBoxEmpfangen.TabStop = false;
            this.groupBoxEmpfangen.Text = "Empfangen";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Senden";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSenden
            // 
            this.textBoxSenden.Location = new System.Drawing.Point(6, 19);
            this.textBoxSenden.Multiline = true;
            this.textBoxSenden.Name = "textBoxSenden";
            this.textBoxSenden.Size = new System.Drawing.Size(291, 151);
            this.textBoxSenden.TabIndex = 1;
            // 
            // textBoxEmpfangen
            // 
            this.textBoxEmpfangen.Location = new System.Drawing.Point(6, 19);
            this.textBoxEmpfangen.Multiline = true;
            this.textBoxEmpfangen.Name = "textBoxEmpfangen";
            this.textBoxEmpfangen.Size = new System.Drawing.Size(291, 203);
            this.textBoxEmpfangen.TabIndex = 0;
            // 
            // buttonSimpelClientStart
            // 
            this.buttonSimpelClientStart.Location = new System.Drawing.Point(131, 12);
            this.buttonSimpelClientStart.Name = "buttonSimpelClientStart";
            this.buttonSimpelClientStart.Size = new System.Drawing.Size(110, 23);
            this.buttonSimpelClientStart.TabIndex = 2;
            this.buttonSimpelClientStart.Text = "TCP Client starten";
            this.buttonSimpelClientStart.UseVisualStyleBackColor = true;
            this.buttonSimpelClientStart.Click += new System.EventHandler(this.buttonSimpelClientStart_Click);
            // 
            // buttonSocketStart
            // 
            this.buttonSocketStart.Location = new System.Drawing.Point(287, 12);
            this.buttonSocketStart.Name = "buttonSocketStart";
            this.buttonSocketStart.Size = new System.Drawing.Size(120, 23);
            this.buttonSocketStart.TabIndex = 4;
            this.buttonSocketStart.Text = "Socker Client starten";
            this.buttonSocketStart.UseVisualStyleBackColor = true;
            this.buttonSocketStart.Click += new System.EventHandler(this.buttonSocketStart_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 492);
            this.Controls.Add(this.buttonSocketStart);
            this.Controls.Add(this.buttonSimpelClientStart);
            this.Controls.Add(this.groupBoxEmpfangen);
            this.Controls.Add(this.groupBoxSenden);
            this.Controls.Add(this.textBoxClientLog);
            this.Controls.Add(this.buttonClientStarten);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.groupBoxSenden.ResumeLayout(false);
            this.groupBoxSenden.PerformLayout();
            this.groupBoxEmpfangen.ResumeLayout(false);
            this.groupBoxEmpfangen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClientStarten;
        public System.Windows.Forms.TextBox textBoxClientLog;
        private System.Windows.Forms.GroupBox groupBoxSenden;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBoxEmpfangen;
        public System.Windows.Forms.TextBox textBoxSenden;
        public System.Windows.Forms.TextBox textBoxEmpfangen;
        private System.Windows.Forms.Button buttonSimpelClientStart;
        private System.Windows.Forms.Button buttonSocketStart;
    }
}