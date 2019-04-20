namespace SoftSong.Interfaces
{
    partial class Adicionar_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adicionar_Produto));
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.cxc_Forn = new Bunifu.Framework.UI.BunifuDropdown();
            this.cxc_Trans = new Bunifu.Framework.UI.BunifuDropdown();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.txt_Preco = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Produto = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Adicionar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Status_QR = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(241, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 77;
            this.label10.Text = "Fornecedora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(76, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "Categoria";
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(484, 22);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(26, 395);
            this.bunifuSeparator3.TabIndex = 75;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // cxc_Forn
            // 
            this.cxc_Forn.BackColor = System.Drawing.Color.Transparent;
            this.cxc_Forn.BorderRadius = 3;
            this.cxc_Forn.ForeColor = System.Drawing.Color.White;
            this.cxc_Forn.Items = new string[0];
            this.cxc_Forn.Location = new System.Drawing.Point(232, 290);
            this.cxc_Forn.Name = "cxc_Forn";
            this.cxc_Forn.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_Forn.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_Forn.selectedIndex = -1;
            this.cxc_Forn.Size = new System.Drawing.Size(190, 28);
            this.cxc_Forn.TabIndex = 67;
            // 
            // cxc_Trans
            // 
            this.cxc_Trans.BackColor = System.Drawing.Color.Transparent;
            this.cxc_Trans.BorderRadius = 3;
            this.cxc_Trans.ForeColor = System.Drawing.Color.White;
            this.cxc_Trans.Items = new string[0];
            this.cxc_Trans.Location = new System.Drawing.Point(65, 290);
            this.cxc_Trans.Name = "cxc_Trans";
            this.cxc_Trans.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_Trans.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_Trans.selectedIndex = -1;
            this.cxc_Trans.Size = new System.Drawing.Size(151, 28);
            this.cxc_Trans.TabIndex = 66;
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Location = new System.Drawing.Point(65, 117);
            this.txt_Descricao.Multiline = true;
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(339, 82);
            this.txt_Descricao.TabIndex = 64;
            // 
            // txt_Preco
            // 
            this.txt_Preco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txt_Preco.BorderColorFocused = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Preco.BorderColorIdle = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Preco.BorderColorMouseHover = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Preco.BorderThickness = 1;
            this.txt_Preco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Preco.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Preco.ForeColor = System.Drawing.Color.White;
            this.txt_Preco.isPassword = false;
            this.txt_Preco.Location = new System.Drawing.Point(65, 223);
            this.txt_Preco.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Preco.Name = "txt_Preco";
            this.txt_Preco.Size = new System.Drawing.Size(96, 30);
            this.txt_Preco.TabIndex = 65;
            this.txt_Preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Produto
            // 
            this.txt_Produto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txt_Produto.BorderColorFocused = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Produto.BorderColorIdle = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Produto.BorderColorMouseHover = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Produto.BorderThickness = 1;
            this.txt_Produto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Produto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Produto.ForeColor = System.Drawing.Color.White;
            this.txt_Produto.isPassword = false;
            this.txt_Produto.Location = new System.Drawing.Point(65, 58);
            this.txt_Produto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Produto.Name = "txt_Produto";
            this.txt_Produto.Size = new System.Drawing.Size(269, 31);
            this.txt_Produto.TabIndex = 63;
            this.txt_Produto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(76, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 74;
            this.label6.Text = "Preço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(76, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Descriçao";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(76, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 72;
            this.label8.Text = "Nome Do Produto";
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_Adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Adicionar.BorderRadius = 0;
            this.btn_Adicionar.ButtonText = "Adicionar";
            this.btn_Adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Adicionar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Adicionar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Adicionar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Adicionar.Iconimage")));
            this.btn_Adicionar.Iconimage_right = null;
            this.btn_Adicionar.Iconimage_right_Selected = null;
            this.btn_Adicionar.Iconimage_Selected = null;
            this.btn_Adicionar.IconMarginLeft = 0;
            this.btn_Adicionar.IconMarginRight = 0;
            this.btn_Adicionar.IconRightVisible = true;
            this.btn_Adicionar.IconRightZoom = 0D;
            this.btn_Adicionar.IconVisible = true;
            this.btn_Adicionar.IconZoom = 90D;
            this.btn_Adicionar.IsTab = false;
            this.btn_Adicionar.Location = new System.Drawing.Point(65, 381);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Adicionar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.btn_Adicionar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.btn_Adicionar.selected = false;
            this.btn_Adicionar.Size = new System.Drawing.Size(151, 36);
            this.btn_Adicionar.TabIndex = 71;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Adicionar.Textcolor = System.Drawing.Color.White;
            this.btn_Adicionar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(532, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 17);
            this.label7.TabIndex = 70;
            this.label7.Text = "Clique para adicionar Foto";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(552, 38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(145, 173);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 69;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Status_QR
            // 
            this.Status_QR.AutoSize = true;
            this.Status_QR.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_QR.Location = new System.Drawing.Point(62, 337);
            this.Status_QR.Name = "Status_QR";
            this.Status_QR.Size = new System.Drawing.Size(0, 17);
            this.Status_QR.TabIndex = 68;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Adicionar_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.cxc_Forn);
            this.Controls.Add(this.cxc_Trans);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.txt_Preco);
            this.Controls.Add(this.txt_Produto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Status_QR);
            this.Name = "Adicionar_Produto";
            this.Size = new System.Drawing.Size(824, 448);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuDropdown cxc_Forn;
        private Bunifu.Framework.UI.BunifuDropdown cxc_Trans;
        private System.Windows.Forms.TextBox txt_Descricao;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Preco;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Produto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Adicionar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label Status_QR;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
