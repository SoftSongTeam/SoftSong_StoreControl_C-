namespace SoftSong.Interfaces
{
    partial class Cadastrar_Transportadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar_Transportadora));
            this.label12 = new System.Windows.Forms.Label();
            this.cxc_UF = new Bunifu.Framework.UI.BunifuDropdown();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_CEP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Cidade = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Endereco = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Nome = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CNPJ = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_Limpar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Tel = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(85, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 17);
            this.label12.TabIndex = 97;
            this.label12.Text = "UF";
            // 
            // cxc_UF
            // 
            this.cxc_UF.BackColor = System.Drawing.Color.Transparent;
            this.cxc_UF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cxc_UF.BorderRadius = 15;
            this.cxc_UF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cxc_UF.ForeColor = System.Drawing.Color.White;
            this.cxc_UF.Items = new string[] {
        "AC",
        "AL",
        "AM",
        "AP",
        "BA",
        "CE",
        "DF",
        "ES",
        "GO",
        "MA",
        "MG",
        "MS",
        "MT",
        "PA",
        "PB",
        "PE",
        "PI",
        "PR",
        "RJ",
        "RN",
        "RO",
        "RR",
        "RS",
        "SC",
        "SE",
        "SP",
        "TO"};
            this.cxc_UF.Location = new System.Drawing.Point(77, 332);
            this.cxc_UF.Name = "cxc_UF";
            this.cxc_UF.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_UF.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_UF.selectedIndex = -1;
            this.cxc_UF.Size = new System.Drawing.Size(103, 24);
            this.cxc_UF.TabIndex = 83;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(204, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 17);
            this.label11.TabIndex = 96;
            this.label11.Text = "CEP";
            // 
            // txt_CEP
            // 
            this.txt_CEP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txt_CEP.BorderColorFocused = System.Drawing.SystemColors.ActiveBorder;
            this.txt_CEP.BorderColorIdle = System.Drawing.SystemColors.ActiveBorder;
            this.txt_CEP.BorderColorMouseHover = System.Drawing.SystemColors.ActiveBorder;
            this.txt_CEP.BorderThickness = 1;
            this.txt_CEP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CEP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_CEP.ForeColor = System.Drawing.Color.White;
            this.txt_CEP.isPassword = false;
            this.txt_CEP.Location = new System.Drawing.Point(197, 332);
            this.txt_CEP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CEP.Name = "txt_CEP";
            this.txt_CEP.Size = new System.Drawing.Size(149, 24);
            this.txt_CEP.TabIndex = 84;
            this.txt_CEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(88, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 95;
            this.label6.Text = "Cidade";
            // 
            // txt_Cidade
            // 
            this.txt_Cidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txt_Cidade.BorderColorFocused = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Cidade.BorderColorIdle = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Cidade.BorderColorMouseHover = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Cidade.BorderThickness = 1;
            this.txt_Cidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Cidade.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Cidade.ForeColor = System.Drawing.Color.White;
            this.txt_Cidade.isPassword = false;
            this.txt_Cidade.Location = new System.Drawing.Point(77, 278);
            this.txt_Cidade.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(269, 24);
            this.txt_Cidade.TabIndex = 82;
            this.txt_Cidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(499, 24);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(45, 387);
            this.bunifuSeparator3.TabIndex = 94;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(571, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 17);
            this.label7.TabIndex = 93;
            this.label7.Text = "Clique para adicionar Foto";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(586, 41);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(158, 173);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 92;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(88, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 91;
            this.label4.Text = "Endereço";
            // 
            // txt_Endereco
            // 
            this.txt_Endereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txt_Endereco.BorderColorFocused = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Endereco.BorderColorIdle = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Endereco.BorderColorMouseHover = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Endereco.BorderThickness = 1;
            this.txt_Endereco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Endereco.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Endereco.ForeColor = System.Drawing.Color.White;
            this.txt_Endereco.isPassword = false;
            this.txt_Endereco.Location = new System.Drawing.Point(77, 231);
            this.txt_Endereco.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(269, 24);
            this.txt_Endereco.TabIndex = 81;
            this.txt_Endereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(88, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 90;
            this.label10.Text = "Nome";
            // 
            // txt_Nome
            // 
            this.txt_Nome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txt_Nome.BorderColorFocused = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Nome.BorderColorIdle = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Nome.BorderColorMouseHover = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Nome.BorderThickness = 1;
            this.txt_Nome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nome.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Nome.ForeColor = System.Drawing.Color.White;
            this.txt_Nome.isPassword = false;
            this.txt_Nome.Location = new System.Drawing.Point(77, 41);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(269, 22);
            this.txt_Nome.TabIndex = 77;
            this.txt_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(88, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 89;
            this.label9.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txt_Email.BorderColorFocused = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Email.BorderColorIdle = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Email.BorderColorMouseHover = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Email.BorderThickness = 1;
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Email.ForeColor = System.Drawing.Color.White;
            this.txt_Email.isPassword = false;
            this.txt_Email.Location = new System.Drawing.Point(77, 85);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(269, 24);
            this.txt_Email.TabIndex = 78;
            this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(88, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 88;
            this.label5.Text = "CNPJ";
            // 
            // txt_CNPJ
            // 
            this.txt_CNPJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txt_CNPJ.BorderColorFocused = System.Drawing.SystemColors.ActiveBorder;
            this.txt_CNPJ.BorderColorIdle = System.Drawing.SystemColors.ActiveBorder;
            this.txt_CNPJ.BorderColorMouseHover = System.Drawing.SystemColors.ActiveBorder;
            this.txt_CNPJ.BorderThickness = 1;
            this.txt_CNPJ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_CNPJ.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_CNPJ.ForeColor = System.Drawing.Color.White;
            this.txt_CNPJ.isPassword = false;
            this.txt_CNPJ.Location = new System.Drawing.Point(77, 136);
            this.txt_CNPJ.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CNPJ.Name = "txt_CNPJ";
            this.txt_CNPJ.Size = new System.Drawing.Size(269, 24);
            this.txt_CNPJ.TabIndex = 79;
            this.txt_CNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Limpar.BorderRadius = 0;
            this.btn_Limpar.ButtonText = "Limpar Campos";
            this.btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Limpar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Limpar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Limpar.Iconimage")));
            this.btn_Limpar.Iconimage_right = null;
            this.btn_Limpar.Iconimage_right_Selected = null;
            this.btn_Limpar.Iconimage_Selected = null;
            this.btn_Limpar.IconMarginLeft = 0;
            this.btn_Limpar.IconMarginRight = 0;
            this.btn_Limpar.IconRightVisible = true;
            this.btn_Limpar.IconRightZoom = 0D;
            this.btn_Limpar.IconVisible = true;
            this.btn_Limpar.IconZoom = 90D;
            this.btn_Limpar.IsTab = false;
            this.btn_Limpar.Location = new System.Drawing.Point(225, 381);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Limpar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.btn_Limpar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.btn_Limpar.selected = false;
            this.btn_Limpar.Size = new System.Drawing.Size(144, 30);
            this.btn_Limpar.TabIndex = 87;
            this.btn_Limpar.Text = "Limpar Campos";
            this.btn_Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpar.Textcolor = System.Drawing.Color.White;
            this.btn_Limpar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Cadastrar";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(64, 381);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(138, 30);
            this.bunifuFlatButton1.TabIndex = 86;
            this.bunifuFlatButton1.Text = "Cadastrar";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(88, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 85;
            this.label8.Text = "Telefone";
            // 
            // txt_Tel
            // 
            this.txt_Tel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txt_Tel.BorderColorFocused = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Tel.BorderColorIdle = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Tel.BorderColorMouseHover = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Tel.BorderThickness = 1;
            this.txt_Tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Tel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Tel.ForeColor = System.Drawing.Color.White;
            this.txt_Tel.isPassword = false;
            this.txt_Tel.Location = new System.Drawing.Point(77, 184);
            this.txt_Tel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(269, 24);
            this.txt_Tel.TabIndex = 80;
            this.txt_Tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Cadastrar_Transportadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cxc_UF);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_CEP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Cidade);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Endereco);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_CNPJ);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Tel);
            this.Name = "Cadastrar_Transportadora";
            this.Size = new System.Drawing.Size(824, 454);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuDropdown cxc_UF;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_CEP;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Cidade;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Endereco;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Nome;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Email;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_CNPJ;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Limpar;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Tel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
