namespace SoftSong.Interfaces
{
    partial class Cadastrar_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar_Cliente));
            this.label12 = new System.Windows.Forms.Label();
            this.cxc_UF = new Bunifu.Framework.UI.BunifuDropdown();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_CEP = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Cidade = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Endereco = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Tel = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_Limpar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Enviar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label6 = new System.Windows.Forms.Label();
            this.cxc_Sexo = new Bunifu.Framework.UI.BunifuDropdown();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CPF = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Email = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nome = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(56, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 17);
            this.label12.TabIndex = 84;
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
            this.cxc_UF.Location = new System.Drawing.Point(48, 348);
            this.cxc_UF.Name = "cxc_UF";
            this.cxc_UF.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_UF.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_UF.selectedIndex = -1;
            this.cxc_UF.Size = new System.Drawing.Size(103, 24);
            this.cxc_UF.TabIndex = 72;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(184, 329);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 17);
            this.label11.TabIndex = 83;
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
            this.txt_CEP.Location = new System.Drawing.Point(177, 347);
            this.txt_CEP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CEP.Name = "txt_CEP";
            this.txt_CEP.Size = new System.Drawing.Size(149, 24);
            this.txt_CEP.TabIndex = 73;
            this.txt_CEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(59, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 17);
            this.label10.TabIndex = 82;
            this.label10.Text = "Cidade";
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
            this.txt_Cidade.Location = new System.Drawing.Point(48, 302);
            this.txt_Cidade.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Cidade.Name = "txt_Cidade";
            this.txt_Cidade.Size = new System.Drawing.Size(269, 24);
            this.txt_Cidade.TabIndex = 71;
            this.txt_Cidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(59, 234);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 17);
            this.label13.TabIndex = 81;
            this.label13.Text = "Endereço";
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
            this.txt_Endereco.Location = new System.Drawing.Point(48, 255);
            this.txt_Endereco.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Endereco.Name = "txt_Endereco";
            this.txt_Endereco.Size = new System.Drawing.Size(269, 24);
            this.txt_Endereco.TabIndex = 69;
            this.txt_Endereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(60, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 80;
            this.label9.Text = "Telefone/Celular";
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
            this.txt_Tel.Location = new System.Drawing.Point(48, 201);
            this.txt_Tel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(269, 27);
            this.txt_Tel.TabIndex = 68;
            this.txt_Tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btn_Limpar.Location = new System.Drawing.Point(471, 373);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Limpar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.btn_Limpar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.btn_Limpar.selected = false;
            this.btn_Limpar.Size = new System.Drawing.Size(144, 30);
            this.btn_Limpar.TabIndex = 79;
            this.btn_Limpar.Text = "Limpar Campos";
            this.btn_Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Limpar.Textcolor = System.Drawing.Color.White;
            this.btn_Limpar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Enviar
            // 
            this.btn_Enviar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_Enviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Enviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Enviar.BorderRadius = 0;
            this.btn_Enviar.ButtonText = "Cadastrar";
            this.btn_Enviar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Enviar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Enviar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Enviar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Enviar.Iconimage")));
            this.btn_Enviar.Iconimage_right = null;
            this.btn_Enviar.Iconimage_right_Selected = null;
            this.btn_Enviar.Iconimage_Selected = null;
            this.btn_Enviar.IconMarginLeft = 0;
            this.btn_Enviar.IconMarginRight = 0;
            this.btn_Enviar.IconRightVisible = true;
            this.btn_Enviar.IconRightZoom = 0D;
            this.btn_Enviar.IconVisible = true;
            this.btn_Enviar.IconZoom = 90D;
            this.btn_Enviar.IsTab = false;
            this.btn_Enviar.Location = new System.Drawing.Point(471, 335);
            this.btn_Enviar.Name = "btn_Enviar";
            this.btn_Enviar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Enviar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.btn_Enviar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.btn_Enviar.selected = false;
            this.btn_Enviar.Size = new System.Drawing.Size(138, 30);
            this.btn_Enviar.TabIndex = 78;
            this.btn_Enviar.Text = "Cadastrar";
            this.btn_Enviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Enviar.Textcolor = System.Drawing.Color.White;
            this.btn_Enviar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enviar.Click += new System.EventHandler(this.btn_Enviar_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(425, 21);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(15, 375);
            this.bunifuSeparator2.TabIndex = 77;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(56, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 76;
            this.label6.Text = "Sexo";
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
            this.cxc_Sexo.Location = new System.Drawing.Point(48, 392);
            this.cxc_Sexo.Name = "cxc_Sexo";
            this.cxc_Sexo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_Sexo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_Sexo.selectedIndex = -1;
            this.cxc_Sexo.Size = new System.Drawing.Size(269, 27);
            this.cxc_Sexo.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(59, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 74;
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
            this.txt_CPF.Location = new System.Drawing.Point(48, 147);
            this.txt_CPF.Margin = new System.Windows.Forms.Padding(4);
            this.txt_CPF.Name = "txt_CPF";
            this.txt_CPF.Size = new System.Drawing.Size(269, 27);
            this.txt_CPF.TabIndex = 66;
            this.txt_CPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(59, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 70;
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
            this.txt_Email.Location = new System.Drawing.Point(48, 94);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(269, 27);
            this.txt_Email.TabIndex = 65;
            this.txt_Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(59, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Nome Cliente";
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
            this.txt_Nome.Location = new System.Drawing.Point(48, 42);
            this.txt_Nome.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(269, 27);
            this.txt_Nome.TabIndex = 64;
            this.txt_Nome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Cadastrar_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cxc_UF);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_CEP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_Cidade);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_Endereco);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Enviar);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cxc_Sexo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_CPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nome);
            this.Name = "Cadastrar_Cliente";
            this.Size = new System.Drawing.Size(824, 448);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuDropdown cxc_UF;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_CEP;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Cidade;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Endereco;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Tel;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Limpar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Enviar;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDropdown cxc_Sexo;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_CPF;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Email;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Nome;
    }
}
