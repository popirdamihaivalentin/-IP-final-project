namespace ProiectIP
{
    public partial class InterfataVizualaMeniu
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
        public void InitializeComponent()
        {
            this.buttonAdaugaCamera = new System.Windows.Forms.Button();
            this.buttonAdaugaUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumarCameraAdaugaCamera = new System.Windows.Forms.TextBox();
            this.labelNumeUser = new System.Windows.Forms.Label();
            this.labelNumarCamera = new System.Windows.Forms.Label();
            this.textBoxNumeUser = new System.Windows.Forms.TextBox();
            this.textBoxNumarCameraAdaugaUser = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdaugaCamera
            // 
            this.buttonAdaugaCamera.Location = new System.Drawing.Point(39, 47);
            this.buttonAdaugaCamera.Name = "buttonAdaugaCamera";
            this.buttonAdaugaCamera.Size = new System.Drawing.Size(221, 74);
            this.buttonAdaugaCamera.TabIndex = 0;
            this.buttonAdaugaCamera.Text = "Adauga Camera";
            this.buttonAdaugaCamera.UseVisualStyleBackColor = true;
            this.buttonAdaugaCamera.Click += new System.EventHandler(this.buttonAdaugaCamera_Click);
            // 
            // buttonAdaugaUser
            // 
            this.buttonAdaugaUser.Location = new System.Drawing.Point(39, 195);
            this.buttonAdaugaUser.Name = "buttonAdaugaUser";
            this.buttonAdaugaUser.Size = new System.Drawing.Size(221, 74);
            this.buttonAdaugaUser.TabIndex = 1;
            this.buttonAdaugaUser.Text = "Adauga User";
            this.buttonAdaugaUser.UseVisualStyleBackColor = true;
            this.buttonAdaugaUser.Click += new System.EventHandler(this.buttonAdaugaUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numar Camera";
            // 
            // textBoxNumarCameraAdaugaCamera
            // 
            this.textBoxNumarCameraAdaugaCamera.Location = new System.Drawing.Point(145, 146);
            this.textBoxNumarCameraAdaugaCamera.Name = "textBoxNumarCameraAdaugaCamera";
            this.textBoxNumarCameraAdaugaCamera.Size = new System.Drawing.Size(113, 22);
            this.textBoxNumarCameraAdaugaCamera.TabIndex = 3;
            // 
            // labelNumeUser
            // 
            this.labelNumeUser.AutoSize = true;
            this.labelNumeUser.Location = new System.Drawing.Point(39, 304);
            this.labelNumeUser.Name = "labelNumeUser";
            this.labelNumeUser.Size = new System.Drawing.Size(79, 17);
            this.labelNumeUser.TabIndex = 4;
            this.labelNumeUser.Text = "Nume User";
            // 
            // labelNumarCamera
            // 
            this.labelNumarCamera.AutoSize = true;
            this.labelNumarCamera.Location = new System.Drawing.Point(39, 341);
            this.labelNumarCamera.Name = "labelNumarCamera";
            this.labelNumarCamera.Size = new System.Drawing.Size(103, 17);
            this.labelNumarCamera.TabIndex = 5;
            this.labelNumarCamera.Text = "Numar Camera";
            // 
            // NumeUser
            // 
            this.textBoxNumeUser.Location = new System.Drawing.Point(145, 299);
            this.textBoxNumeUser.Name = "NumeUser";
            this.textBoxNumeUser.Size = new System.Drawing.Size(113, 22);
            this.textBoxNumeUser.TabIndex = 6;
            // 
            // NumarCameraAdaugaUser
            // 
            this.textBoxNumarCameraAdaugaUser.Location = new System.Drawing.Point(145, 341);
            this.textBoxNumarCameraAdaugaUser.Name = "NumarCameraAdaugaUser";
            this.textBoxNumarCameraAdaugaUser.Size = new System.Drawing.Size(113, 22);
            this.textBoxNumarCameraAdaugaUser.TabIndex = 7;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(253, 11);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(35, 30);
            this.buttonHelp.TabIndex = 8;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // InterfataVizualaMeniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 404);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.textBoxNumarCameraAdaugaUser);
            this.Controls.Add(this.textBoxNumeUser);
            this.Controls.Add(this.labelNumarCamera);
            this.Controls.Add(this.labelNumeUser);
            this.Controls.Add(this.textBoxNumarCameraAdaugaCamera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdaugaUser);
            this.Controls.Add(this.buttonAdaugaCamera);
            this.Name = "InterfataVizualaMeniu";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonAdaugaCamera;
        public System.Windows.Forms.Button buttonAdaugaUser;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxNumarCameraAdaugaCamera;
        public System.Windows.Forms.Label labelNumeUser;
        public System.Windows.Forms.Label labelNumarCamera;
        public System.Windows.Forms.TextBox textBoxNumeUser;
        public System.Windows.Forms.TextBox textBoxNumarCameraAdaugaUser;
        public System.Windows.Forms.Button buttonHelp;
    }
}

