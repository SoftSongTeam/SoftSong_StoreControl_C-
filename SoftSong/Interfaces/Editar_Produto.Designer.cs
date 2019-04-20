namespace SoftSong.Interfaces
{
    partial class Editar_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar_Produto));
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cxc_Forn = new Bunifu.Framework.UI.BunifuDropdown();
            this.cxc_Trans = new Bunifu.Framework.UI.BunifuDropdown();
            this.txt_Descricao = new System.Windows.Forms.TextBox();
            this.txt_Preco = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_Produto = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btn_Excluir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Editar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(252, 282);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 17);
            this.label10.TabIndex = 81;
            this.label10.Text = "Fornecedora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(87, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 80;
            this.label4.Text = "Categoria";
            // 
            // cxc_Forn
            // 
            this.cxc_Forn.BackColor = System.Drawing.Color.Transparent;
            this.cxc_Forn.BorderRadius = 3;
            this.cxc_Forn.ForeColor = System.Drawing.Color.White;
            this.cxc_Forn.Items = new string[0];
            this.cxc_Forn.Location = new System.Drawing.Point(243, 302);
            this.cxc_Forn.Name = "cxc_Forn";
            this.cxc_Forn.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_Forn.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_Forn.selectedIndex = -1;
            this.cxc_Forn.Size = new System.Drawing.Size(151, 28);
            this.cxc_Forn.TabIndex = 79;
            // 
            // cxc_Trans
            // 
            this.cxc_Trans.BackColor = System.Drawing.Color.Transparent;
            this.cxc_Trans.BorderRadius = 3;
            this.cxc_Trans.ForeColor = System.Drawing.Color.White;
            this.cxc_Trans.Items = new string[0];
            this.cxc_Trans.Location = new System.Drawing.Point(76, 302);
            this.cxc_Trans.Name = "cxc_Trans";
            this.cxc_Trans.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_Trans.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_Trans.selectedIndex = -1;
            this.cxc_Trans.Size = new System.Drawing.Size(151, 28);
            this.cxc_Trans.TabIndex = 78;
            // 
            // txt_Descricao
            // 
            this.txt_Descricao.Location = new System.Drawing.Point(76, 125);
            this.txt_Descricao.Multiline = true;
            this.txt_Descricao.Name = "txt_Descricao";
            this.txt_Descricao.Size = new System.Drawing.Size(269, 85);
            this.txt_Descricao.TabIndex = 77;
            // 
            // txt_Preco
            // 
            this.txt_Preco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txt_Preco.BorderColorFocused = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Preco.BorderColorIdle = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Preco.BorderColorMouseHover = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Preco.BorderThickness = 1;
            this.txt_Preco.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Preco.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Preco.ForeColor = System.Drawing.Color.White;
            this.txt_Preco.isPassword = false;
            this.txt_Preco.Location = new System.Drawing.Point(76, 239);
            this.txt_Preco.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Preco.Name = "txt_Preco";
            this.txt_Preco.Size = new System.Drawing.Size(96, 31);
            this.txt_Preco.TabIndex = 76;
            this.txt_Preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_Produto
            // 
            this.txt_Produto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txt_Produto.BorderColorFocused = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Produto.BorderColorIdle = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Produto.BorderColorMouseHover = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Produto.BorderThickness = 1;
            this.txt_Produto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Produto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Produto.ForeColor = System.Drawing.Color.White;
            this.txt_Produto.isPassword = false;
            this.txt_Produto.Location = new System.Drawing.Point(76, 57);
            this.txt_Produto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Produto.Name = "txt_Produto";
            this.txt_Produto.Size = new System.Drawing.Size(269, 31);
            this.txt_Produto.TabIndex = 75;
            this.txt_Produto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btn_Excluir.Location = new System.Drawing.Point(243, 370);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Excluir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.btn_Excluir.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.btn_Excluir.selected = false;
            this.btn_Excluir.Size = new System.Drawing.Size(151, 36);
            this.btn_Excluir.TabIndex = 74;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Excluir.Textcolor = System.Drawing.Color.White;
            this.btn_Excluir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Editar.BorderRadius = 0;
            this.btn_Editar.ButtonText = "Atualizar";
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Editar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Editar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Editar.Iconimage")));
            this.btn_Editar.Iconimage_right = null;
            this.btn_Editar.Iconimage_right_Selected = null;
            this.btn_Editar.Iconimage_Selected = null;
            this.btn_Editar.IconMarginLeft = 0;
            this.btn_Editar.IconMarginRight = 0;
            this.btn_Editar.IconRightVisible = true;
            this.btn_Editar.IconRightZoom = 0D;
            this.btn_Editar.IconVisible = true;
            this.btn_Editar.IconZoom = 90D;
            this.btn_Editar.IsTab = false;
            this.btn_Editar.Location = new System.Drawing.Point(69, 370);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Editar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.btn_Editar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.btn_Editar.selected = false;
            this.btn_Editar.Size = new System.Drawing.Size(151, 36);
            this.btn_Editar.TabIndex = 73;
            this.btn_Editar.Text = "Atualizar";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.Textcolor = System.Drawing.Color.White;
            this.btn_Editar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(516, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 17);
            this.label7.TabIndex = 72;
            this.label7.Text = "Clique para adicionar Foto";
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(477, 31);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(15, 375);
            this.bunifuSeparator2.TabIndex = 71;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(537, 55);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 153);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 70;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(88, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 69;
            this.label6.Text = "Preço";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(87, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Descriçao";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(87, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 67;
            this.label8.Text = "Nome Do Produto";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Editar_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cxc_Forn);
            this.Controls.Add(this.cxc_Trans);
            this.Controls.Add(this.txt_Descricao);
            this.Controls.Add(this.txt_Preco);
            this.Controls.Add(this.txt_Produto);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Name = "Editar_Produto";
            this.Size = new System.Drawing.Size(824, 448);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDropdown cxc_Forn;
        private Bunifu.Framework.UI.BunifuDropdown cxc_Trans;
        private System.Windows.Forms.TextBox txt_Descricao;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Preco;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Produto;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Excluir;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Editar;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
