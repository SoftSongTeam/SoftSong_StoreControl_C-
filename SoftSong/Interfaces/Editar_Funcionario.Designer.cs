namespace SoftSong.Interfaces
{
    partial class Editar_Funcionario
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Funcionario));
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Senha = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Tel = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.cxc_Sexo = new Bunifu.Framework.UI.BunifuDropdown();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Nome = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CPF = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_Excluir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Atualizar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(61, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 109;
            this.label10.Text = "Senha";
            // 
            // txt_Senha
            // 
            this.txt_Senha.BorderColorFocused = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Senha.BorderColorIdle = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Senha.BorderColorMouseHover = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Senha.BorderThickness = 1;
            this.txt_Senha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Senha.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Senha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Senha.isPassword = false;
            this.txt_Senha.Location = new System.Drawing.Point(50, 309);
            this.txt_Senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(269, 31);
            this.txt_Senha.TabIndex = 108;
            this.txt_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(62, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 107;
            this.label6.Text = "Telefone/Celular";
            // 
            // txt_Tel
            // 
            this.txt_Tel.BorderColorFocused = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Tel.BorderColorIdle = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Tel.BorderColorMouseHover = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Tel.BorderThickness = 1;
            this.txt_Tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Tel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Tel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Tel.isPassword = false;
            this.txt_Tel.Location = new System.Drawing.Point(50, 204);
            this.txt_Tel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(269, 27);
            this.txt_Tel.TabIndex = 104;
            this.txt_Tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(58, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 106;
            this.label8.Text = "Sexo";
            // 
            // cxc_Sexo
            // 
            this.cxc_Sexo.BackColor = System.Drawing.Color.Transparent;
            this.cxc_Sexo.BorderRadius = 3;
            this.cxc_Sexo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cxc_Sexo.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.cxc_Sexo.Items = new string[] {
        "Outros",
        "Masculino",
        "Feminino",
        "Nao quero identificar"};
            this.cxc_Sexo.Location = new System.Drawing.Point(50, 257);
            this.cxc_Sexo.Name = "cxc_Sexo";
            this.cxc_Sexo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_Sexo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_Sexo.selectedIndex = -1;
            this.cxc_Sexo.Size = new System.Drawing.Size(269, 27);
            this.cxc_Sexo.TabIndex = 105;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(61, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 103;
            this.label9.Text = "Nome";
            // 
            // txt_Nome
            // 
            this.txt_Nome.BorderColorFocused = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Nome.BorderColorIdle = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Nome.BorderColorMouseHover = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Nome.BorderThickness = 1;
            this.txt_Nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Nome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Nome.isPassword = false;
            this.txt_Nome.Location = new System.Drawing.Point(50, 47);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(269, 31);
            this.txt_Nome.TabIndex = 102;
            this.txt_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(61, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 101;
            this.label4.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.BorderColorFocused = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Email.BorderColorIdle = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Email.BorderColorMouseHover = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Email.BorderThickness = 1;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Email.isPassword = false;
            this.txt_Email.Location = new System.Drawing.Point(50, 101);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(269, 31);
            this.txt_Email.TabIndex = 100;
            this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(61, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 99;
            this.label5.Text = "CPF";
            // 
            // txt_CPF
            // 
            this.txt_CPF.BorderColorFocused = System.Drawing.SystemColors.ActiveBorder;
            this.txt_CPF.BorderColorIdle = System.Drawing.SystemColors.ActiveBorder;
            this.txt_CPF.BorderColorMouseHover = System.Drawing.SystemColors.ActiveBorder;
            this.txt_CPF.BorderThickness = 1;
            this.txt_CPF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CPF.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_CPF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_CPF.isPassword = false;
            this.txt_CPF.Location = new System.Drawing.Point(50, 151);
            this.txt_CPF.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(269, 31);
            this.txt_CPF.TabIndex = 98;
            this.txt_CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_Excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Excluir.BorderRadius = 0;
            this.btn_Excluir.ButtonText = "Excluir";
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Excluir.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Excluir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Excluir.Iconimage")));
            this.btn_Excluir.Iconimage_right = null;
            this.btn_Excluir.Iconimage_right_Selected = null;
            this.btn_Excluir.Iconimage_Selected = null;
            this.btn_Excluir.IconMarginLeft = 0;
            this.btn_Excluir.IconMarginRight = 0;
            this.btn_Excluir.IconRightVisible = true;
            this.btn_Excluir.IconRightZoom = 0D;
            this.btn_Excluir.IconVisible = true;
            this.btn_Excluir.IconZoom = 90D;
            this.btn_Excluir.IsTab = false;
            this.btn_Excluir.Location = new System.Drawing.Point(212, 369);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Excluir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.btn_Excluir.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.btn_Excluir.selected = false;
            this.btn_Excluir.Size = new System.Drawing.Size(151, 30);
            this.btn_Excluir.TabIndex = 97;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excluir.Textcolor = System.Drawing.Color.White;
            this.btn_Excluir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(503, 43);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(153, 160);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 93;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(449, 24);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(15, 375);
            this.bunifuSeparator2.TabIndex = 94;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(487, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 17);
            this.label7.TabIndex = 95;
            this.label7.Text = "Clique para adicionar Foto";
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Atualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Atualizar.BorderRadius = 0;
            this.btn_Atualizar.ButtonText = "Atualizar";
            this.btn_Atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Atualizar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Atualizar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Atualizar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Atualizar.Iconimage")));
            this.btn_Atualizar.Iconimage_right = null;
            this.btn_Atualizar.Iconimage_right_Selected = null;
            this.btn_Atualizar.Iconimage_Selected = null;
            this.btn_Atualizar.IconMarginLeft = 0;
            this.btn_Atualizar.IconMarginRight = 0;
            this.btn_Atualizar.IconRightVisible = true;
            this.btn_Atualizar.IconRightZoom = 0D;
            this.btn_Atualizar.IconVisible = true;
            this.btn_Atualizar.IconZoom = 90D;
            this.btn_Atualizar.IsTab = false;
            this.btn_Atualizar.Location = new System.Drawing.Point(50, 369);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Atualizar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.btn_Atualizar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.btn_Atualizar.selected = false;
            this.btn_Atualizar.Size = new System.Drawing.Size(138, 30);
            this.btn_Atualizar.TabIndex = 96;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Atualizar.Textcolor = System.Drawing.Color.White;
            this.btn_Atualizar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Editar_Funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cxc_Sexo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_CPF);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Atualizar);
            this.Name = "Editar_Funcionario";
            this.Size = new System.Drawing.Size(824, 448);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Senha;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Tel;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuDropdown cxc_Sexo;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Nome;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Email;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_CPF;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Excluir;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Atualizar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
