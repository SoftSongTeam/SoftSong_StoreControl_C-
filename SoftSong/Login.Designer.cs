namespace SoftSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Senha = new Bunifu.Framework.UI.BunifuTextbox();
            this.txt_Copia = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Login = new Bunifu.Framework.UI.BunifuTextbox();
            this.btn_Login = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(81, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login SoftSong";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(362, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 32);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_Senha
            // 
            this.txt_Senha.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Senha.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Senha.BackgroundImage")));
            this.txt_Senha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txt_Senha.Icon = ((System.Drawing.Image)(resources.GetObject("txt_Senha.Icon")));
            this.txt_Senha.Location = new System.Drawing.Point(21, 177);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(359, 48);
            this.txt_Senha.TabIndex = 2;
            this.txt_Senha.text = "";
            this.txt_Senha.KeyUp += new System.EventHandler(this.txt_Senha_KeyUp);
            this.txt_Senha.Click += new System.EventHandler(this.txt_Senha_Click);
            this.txt_Senha.MouseEnter += new System.EventHandler(this.txt_Senha_MouseEnter);
            this.txt_Senha.MouseHover += new System.EventHandler(this.txt_Senha_MouseHover);
            // 
            // txt_Copia
            // 
            this.txt_Copia.Location = new System.Drawing.Point(25, 28);
            this.txt_Copia.Name = "txt_Copia";
            this.txt_Copia.Size = new System.Drawing.Size(100, 20);
            this.txt_Copia.TabIndex = 5;
            this.txt_Copia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Copia_KeyPress);
            this.txt_Copia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Copia_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Copia);
            this.panel1.Location = new System.Drawing.Point(379, 309);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 6;
            // 
            // txt_Login
            // 
            this.txt_Login.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Login.BackgroundImage")));
            this.txt_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txt_Login.Icon = ((System.Drawing.Image)(resources.GetObject("txt_Login.Icon")));
            this.txt_Login.Location = new System.Drawing.Point(21, 105);
            this.txt_Login.Name = "txt_Login";
            this.txt_Login.Size = new System.Drawing.Size(359, 48);
            this.txt_Login.TabIndex = 1;
            this.txt_Login.text = "";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btn_Login.Image = ((System.Drawing.Image)(resources.GetObject("btn_Login.Image")));
            this.btn_Login.ImageActive = null;
            this.btn_Login.Location = new System.Drawing.Point(25, 279);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(176, 40);
            this.btn_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Login.TabIndex = 8;
            this.btn_Login.TabStop = false;
            this.btn_Login.Zoom = 10;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(401, 356);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Login);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuTextbox txt_Senha;
        private System.Windows.Forms.TextBox txt_Copia;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuTextbox txt_Login;
        private Bunifu.Framework.UI.BunifuImageButton btn_Login;
    }
}