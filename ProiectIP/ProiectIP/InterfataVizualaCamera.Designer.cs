namespace ProiectIP
{
    partial class InterfataVizualaCamera
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
            this.textBoxConversatie = new System.Windows.Forms.TextBox();
            this.textBoxBuffer = new System.Windows.Forms.TextBox();
            this.buttonTrimite = new System.Windows.Forms.Button();
            this.textBoxNumeUtilizator = new System.Windows.Forms.TextBox();
            this.textBoxNumarCamera = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.textBoxParticipanti = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxConversatie
            // 
            this.textBoxConversatie.Location = new System.Drawing.Point(32, 42);
            this.textBoxConversatie.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxConversatie.Multiline = true;
            this.textBoxConversatie.Name = "textBoxConversatie";
            this.textBoxConversatie.ReadOnly = true;
            this.textBoxConversatie.Size = new System.Drawing.Size(277, 168);
            this.textBoxConversatie.TabIndex = 0;
            // 
            // textBoxBuffer
            // 
            this.textBoxBuffer.Location = new System.Drawing.Point(32, 228);
            this.textBoxBuffer.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuffer.Multiline = true;
            this.textBoxBuffer.Name = "textBoxBuffer";
            this.textBoxBuffer.Size = new System.Drawing.Size(276, 44);
            this.textBoxBuffer.TabIndex = 1;
            // 
            // buttonTrimite
            // 
            this.buttonTrimite.Location = new System.Drawing.Point(321, 228);
            this.buttonTrimite.Margin = new System.Windows.Forms.Padding(2);
            this.buttonTrimite.Name = "buttonTrimite";
            this.buttonTrimite.Size = new System.Drawing.Size(62, 43);
            this.buttonTrimite.TabIndex = 2;
            this.buttonTrimite.Text = "Trimite";
            this.buttonTrimite.UseVisualStyleBackColor = true;
            this.buttonTrimite.Click += new System.EventHandler(this.buttonTrimite_Click);
            // 
            // textBoxNumeUtilizator
            // 
            this.textBoxNumeUtilizator.Location = new System.Drawing.Point(32, 10);
            this.textBoxNumeUtilizator.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumeUtilizator.Name = "textBoxNumeUtilizator";
            this.textBoxNumeUtilizator.ReadOnly = true;
            this.textBoxNumeUtilizator.Size = new System.Drawing.Size(159, 20);
            this.textBoxNumeUtilizator.TabIndex = 3;
            // 
            // textBoxNumarCamera
            // 
            this.textBoxNumarCamera.Location = new System.Drawing.Point(195, 10);
            this.textBoxNumarCamera.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNumarCamera.Name = "textBoxNumarCamera";
            this.textBoxNumarCamera.ReadOnly = true;
            this.textBoxNumarCamera.Size = new System.Drawing.Size(114, 20);
            this.textBoxNumarCamera.TabIndex = 4;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(363, 10);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(24, 21);
            this.buttonHelp.TabIndex = 5;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // textBoxParticipanti
            // 
            this.textBoxParticipanti.Location = new System.Drawing.Point(316, 42);
            this.textBoxParticipanti.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxParticipanti.Multiline = true;
            this.textBoxParticipanti.Name = "textBoxParticipanti";
            this.textBoxParticipanti.ReadOnly = true;
            this.textBoxParticipanti.Size = new System.Drawing.Size(68, 167);
            this.textBoxParticipanti.TabIndex = 6;
            // 
            // InterfataVizualaCamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 285);
            this.Controls.Add(this.textBoxParticipanti);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.textBoxNumarCamera);
            this.Controls.Add(this.textBoxNumeUtilizator);
            this.Controls.Add(this.buttonTrimite);
            this.Controls.Add(this.textBoxBuffer);
            this.Controls.Add(this.textBoxConversatie);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "InterfataVizualaCamera";
            this.Text = "Camera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxConversatie;
        public System.Windows.Forms.TextBox textBoxBuffer;
        public System.Windows.Forms.Button buttonTrimite;
        public System.Windows.Forms.TextBox textBoxNumeUtilizator;
        public System.Windows.Forms.TextBox textBoxNumarCamera;
        public System.Windows.Forms.Button buttonHelp;
        public System.Windows.Forms.TextBox textBoxParticipanti;
    }
}