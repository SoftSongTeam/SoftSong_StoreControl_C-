namespace SoftSong.Interfaces
{
    partial class Cadastrar_Promocao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar_Promocao));
            this.btn_Editar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_Tempo = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Preco = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Editar
            // 
            this.btn_Editar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btn_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Editar.BorderRadius = 0;
            this.btn_Editar.ButtonText = "Adicionar Promoçao";
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
            this.btn_Editar.Location = new System.Drawing.Point(59, 202);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(50)))), ((int)(((byte)(80)))));
            this.btn_Editar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(156)))));
            this.btn_Editar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(192)))), ((int)(((byte)(217)))));
            this.btn_Editar.selected = false;
            this.btn_Editar.Size = new System.Drawing.Size(184, 34);
            this.btn_Editar.TabIndex = 58;
            this.btn_Editar.Text = "Adicionar Promoçao";
            this.btn_Editar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Editar.Textcolor = System.Drawing.Color.White;
            this.btn_Editar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // txt_Tempo
            // 
            this.txt_Tempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txt_Tempo.BorderColorFocused = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Tempo.BorderColorIdle = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Tempo.BorderColorMouseHover = System.Drawing.SystemColors.ActiveBorder;
            this.txt_Tempo.BorderThickness = 1;
            this.txt_Tempo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Tempo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Tempo.ForeColor = System.Drawing.Color.White;
            this.txt_Tempo.isPassword = false;
            this.txt_Tempo.Location = new System.Drawing.Point(197, 122);
            this.txt_Tempo.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tempo.Name = "txt_Tempo";
            this.txt_Tempo.Size = new System.Drawing.Size(96, 31);
            this.txt_Tempo.TabIndex = 57;
            this.txt_Tempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Tempo.OnValueChanged += new System.EventHandler(this.txt_Tempo_OnValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(194, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Tempo de Permanencia";
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
            this.txt_Preco.Location = new System.Drawing.Point(59, 122);
            this.txt_Preco.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Preco.Name = "txt_Preco";
            this.txt_Preco.Size = new System.Drawing.Size(96, 31);
            this.txt_Preco.TabIndex = 55;
            this.txt_Preco.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(71, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Preço";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(71, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 24);
            this.label8.TabIndex = 53;
            this.label8.Text = "Nome Do Produto";
            // 
            // Cadastrar_Promocao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.txt_Tempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Preco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Name = "Cadastrar_Promocao";
            this.Size = new System.Drawing.Size(824, 448);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_Editar;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Tempo;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Preco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
}
