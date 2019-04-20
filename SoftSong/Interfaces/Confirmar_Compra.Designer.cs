namespace SoftSong.Interfaces
{
    partial class Confirmar_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Confirmar_Compra));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Final = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label10 = new System.Windows.Forms.Label();
            this.cxc_Trans = new Bunifu.Framework.UI.BunifuDropdown();
            this.txt_Pesquisar = new Bunifu.Framework.UI.BunifuTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Final
            // 
            this.btn_Final.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
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
            this.btn_Final.Location = new System.Drawing.Point(527, 359);
            this.btn_Final.Name = "btn_Final";
            this.btn_Final.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Final.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.btn_Final.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.btn_Final.selected = false;
            this.btn_Final.Size = new System.Drawing.Size(156, 31);
            this.btn_Final.TabIndex = 71;
            this.btn_Final.Text = "Finalizar compra";
            this.btn_Final.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Final.Textcolor = System.Drawing.Color.White;
            this.btn_Final.TextFont = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Final.Click += new System.EventHandler(this.btn_Final_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(51, 305);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 70;
            this.label10.Text = "Transportadora";
            // 
            // cxc_Trans
            // 
            this.cxc_Trans.BackColor = System.Drawing.Color.Transparent;
            this.cxc_Trans.BorderRadius = 3;
            this.cxc_Trans.ForeColor = System.Drawing.Color.White;
            this.cxc_Trans.Items = new string[0];
            this.cxc_Trans.Location = new System.Drawing.Point(54, 325);
            this.cxc_Trans.Name = "cxc_Trans";
            this.cxc_Trans.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_Trans.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.cxc_Trans.selectedIndex = -1;
            this.cxc_Trans.Size = new System.Drawing.Size(210, 28);
            this.cxc_Trans.TabIndex = 69;
            // 
            // txt_Pesquisar
            // 
            this.txt_Pesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.txt_Pesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_Pesquisar.BackgroundImage")));
            this.txt_Pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txt_Pesquisar.ForeColor = System.Drawing.Color.SeaShell;
            this.txt_Pesquisar.Icon = ((System.Drawing.Image)(resources.GetObject("txt_Pesquisar.Icon")));
            this.txt_Pesquisar.Location = new System.Drawing.Point(54, 48);
            this.txt_Pesquisar.Name = "txt_Pesquisar";
            this.txt_Pesquisar.Size = new System.Drawing.Size(377, 31);
            this.txt_Pesquisar.TabIndex = 68;
            this.txt_Pesquisar.text = "";
            this.txt_Pesquisar.OnTextChange += new System.EventHandler(this.txt_Pesquisar_OnTextChange);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(65, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 17);
            this.label8.TabIndex = 67;
            this.label8.Text = "Selecione o Cliente que realizou a compra";
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
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(54, 85);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(412, 204);
            this.bunifuCustomDataGrid1.TabIndex = 66;
            this.bunifuCustomDataGrid1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellDoubleClick);
            // 
            // Confirmar_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btn_Final);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cxc_Trans);
            this.Controls.Add(this.txt_Pesquisar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Name = "Confirmar_Compra";
            this.Size = new System.Drawing.Size(824, 448);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Bunifu.Framework.UI.BunifuFlatButton btn_Final;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuDropdown cxc_Trans;
        private Bunifu.Framework.UI.BunifuTextbox txt_Pesquisar;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
    }
}
