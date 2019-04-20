namespace SoftSong.Interfaces
{
    partial class Carrinho
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Limpar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Final = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Preco = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Limpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Limpar.BorderRadius = 0;
            this.btn_Limpar.ButtonText = "Limpar carrinho";
            this.btn_Limpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Limpar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Limpar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Limpar.Iconimage = null;
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
            this.btn_Limpar.Location = new System.Drawing.Point(348, 371);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Limpar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.btn_Limpar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.btn_Limpar.selected = false;
            this.btn_Limpar.Size = new System.Drawing.Size(156, 31);
            this.btn_Limpar.TabIndex = 58;
            this.btn_Limpar.Text = "Limpar carrinho";
            this.btn_Limpar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Limpar.Textcolor = System.Drawing.Color.White;
            this.btn_Limpar.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Final
            // 
            this.btn_Final.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Final.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Final.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Final.BorderRadius = 0;
            this.btn_Final.ButtonText = "Finalizar compra";
            this.btn_Final.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Final.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Final.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Final.Iconimage = null;
            this.btn_Final.Iconimage_right = null;
            this.btn_Final.Iconimage_right_Selected = null;
            this.btn_Final.Iconimage_Selected = null;
            this.btn_Final.IconMarginLeft = 0;
            this.btn_Final.IconMarginRight = 0;
            this.btn_Final.IconRightVisible = true;
            this.btn_Final.IconRightZoom = 0D;
            this.btn_Final.IconVisible = true;
            this.btn_Final.IconZoom = 90D;
            this.btn_Final.IsTab = false;
            this.btn_Final.Location = new System.Drawing.Point(520, 371);
            this.btn_Final.Name = "btn_Final";
            this.btn_Final.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Final.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.btn_Final.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.btn_Final.selected = false;
            this.btn_Final.Size = new System.Drawing.Size(156, 31);
            this.btn_Final.TabIndex = 57;
            this.btn_Final.Text = "Finalizar compra";
            this.btn_Final.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Final.Textcolor = System.Drawing.Color.White;
            this.btn_Final.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Final.Click += new System.EventHandler(this.btn_Final_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(82, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(344, 17);
            this.label8.TabIndex = 56;
            this.label8.Text = "Clique em algum dos itens para remover do crrinho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(99, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 23);
            this.label6.TabIndex = 55;
            this.label6.Text = "Valor Total:";
            // 
            // txt_Preco
            // 
            this.txt_Preco.AutoSize = true;
            this.txt_Preco.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Preco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_Preco.Location = new System.Drawing.Point(99, 352);
            this.txt_Preco.Name = "txt_Preco";
            this.txt_Preco.Size = new System.Drawing.Size(121, 39);
            this.txt_Preco.TabIndex = 54;
            this.txt_Preco.Text = "R$ 3999";
            // 
            // bunifuCustomDataGrid1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(126)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(126)))), ((int)(((byte)(115)))));
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(71, 62);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(465, 234);
            this.bunifuCustomDataGrid1.TabIndex = 53;
            this.bunifuCustomDataGrid1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellDoubleClick);
            // 
            // Carrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Final);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_Preco);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Name = "Carrinho";
            this.Size = new System.Drawing.Size(824, 448);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuFlatButton btn_Limpar;
        public Bunifu.Framework.UI.BunifuFlatButton btn_Final;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txt_Preco;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
    }
}
