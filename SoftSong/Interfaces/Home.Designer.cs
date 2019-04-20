namespace SoftSong.Interfaces
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Items = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_Logoff = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_Pesquisar = new Bunifu.Framework.UI.BunifuTextbox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(79, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Abrir Carrinho";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_Items
            // 
            this.lbl_Items.AutoSize = true;
            this.lbl_Items.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Items.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Items.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Items.Location = new System.Drawing.Point(112, 218);
            this.lbl_Items.Name = "lbl_Items";
            this.lbl_Items.Size = new System.Drawing.Size(79, 23);
            this.lbl_Items.TabIndex = 23;
            this.lbl_Items.Text = "0 Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(105, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Carrinho";
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(233, 44);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(14, 317);
            this.bunifuSeparator3.TabIndex = 22;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(92, 69);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(111, 109);
            this.pictureBox4.TabIndex = 18;
            this.pictureBox4.TabStop = false;
            // 
            // btn_Logoff
            // 
            this.btn_Logoff.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(126)))), ((int)(((byte)(115)))));
            this.btn_Logoff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Logoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Logoff.BorderRadius = 0;
            this.btn_Logoff.ButtonText = "Logoff";
            this.btn_Logoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Logoff.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Logoff.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Logoff.Iconimage = null;
            this.btn_Logoff.Iconimage_right = null;
            this.btn_Logoff.Iconimage_right_Selected = null;
            this.btn_Logoff.Iconimage_Selected = null;
            this.btn_Logoff.IconMarginLeft = 0;
            this.btn_Logoff.IconMarginRight = 0;
            this.btn_Logoff.IconRightVisible = true;
            this.btn_Logoff.IconRightZoom = 0D;
            this.btn_Logoff.IconVisible = true;
            this.btn_Logoff.IconZoom = 90D;
            this.btn_Logoff.IsTab = false;
            this.btn_Logoff.Location = new System.Drawing.Point(606, 378);
            this.btn_Logoff.Name = "btn_Logoff";
            this.btn_Logoff.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Logoff.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.btn_Logoff.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(208)))), ((int)(((byte)(230)))));
            this.btn_Logoff.selected = false;
            this.btn_Logoff.Size = new System.Drawing.Size(166, 31);
            this.btn_Logoff.TabIndex = 20;
            this.btn_Logoff.Text = "Logoff";
            this.btn_Logoff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Logoff.Textcolor = System.Drawing.Color.White;
            this.btn_Logoff.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logoff.Click += new System.EventHandler(this.btn_Logoff_Click);
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txt_Pesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Pesquisar.BackgroundImage")));
            this.txt_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Pesquisar.ForeColor = System.Drawing.Color.SeaShell;
            this.txt_Pesquisar.Icon = ((System.Drawing.Image)(resources.GetObject("txt_Pesquisar.Icon")));
            this.txt_Pesquisar.Location = new System.Drawing.Point(395, 69);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(377, 31);
            this.txt_Pesquisar.TabIndex = 19;
            this.txt_Pesquisar.text = "";
            this.txt_Pesquisar.OnTextChange += new System.EventHandler(this.txt_Pesquisar_OnTextChange);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(356, 106);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(416, 214);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Items);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuSeparator3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btn_Logoff);
            this.Controls.Add(this.txt_Pesquisar);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(824, 448);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_Items;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        public System.Windows.Forms.PictureBox pictureBox4;
        public Bunifu.Framework.UI.BunifuFlatButton btn_Logoff;
        private Bunifu.Framework.UI.BunifuTextbox txt_Pesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
