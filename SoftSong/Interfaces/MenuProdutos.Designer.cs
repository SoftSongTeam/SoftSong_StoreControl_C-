namespace SoftSong.Interfaces
{
    partial class MenuProdutos
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuProdutos));
            this.Edit_Prod = new System.Windows.Forms.PictureBox();
            this.Add_Prod = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Prod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Prod)).BeginInit();
            this.SuspendLayout();
            // 
            // Edit_Prod
            // 
            this.Edit_Prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PanelAnimator.SetDecoration(this.Edit_Prod, BunifuAnimatorNS.DecorationType.None);
            this.Edit_Prod.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Prod.Image")));
            this.Edit_Prod.Location = new System.Drawing.Point(512, 104);
            this.Edit_Prod.Name = "Edit_Prod";
            this.Edit_Prod.Size = new System.Drawing.Size(200, 200);
            this.Edit_Prod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Edit_Prod.TabIndex = 32;
            this.Edit_Prod.TabStop = false;
            this.Edit_Prod.Click += new System.EventHandler(this.Edit_Prod_Click);
            this.Edit_Prod.MouseHover += new System.EventHandler(this.Edit_Prod_MouseHover);
            // 
            // Add_Prod
            // 
            this.Add_Prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PanelAnimator.SetDecoration(this.Add_Prod, BunifuAnimatorNS.DecorationType.None);
            this.Add_Prod.Image = ((System.Drawing.Image)(resources.GetObject("Add_Prod.Image")));
            this.Add_Prod.Location = new System.Drawing.Point(92, 104);
            this.Add_Prod.Name = "Add_Prod";
            this.Add_Prod.Size = new System.Drawing.Size(200, 200);
            this.Add_Prod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Add_Prod.TabIndex = 31;
            this.Add_Prod.TabStop = false;
            this.Add_Prod.Click += new System.EventHandler(this.Add_Prod_Click);
            this.Add_Prod.MouseHover += new System.EventHandler(this.Add_Prod_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(101, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Adicionar Produtos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(525, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 34;
            this.label1.Text = "Editar Funcionarios";
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.PanelAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(0);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 1F;
            this.PanelAnimator.DefaultAnimation = animation4;
            this.PanelAnimator.TimeStep = 0.01F;
            // 
            // MenuProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Edit_Prod);
            this.Controls.Add(this.Add_Prod);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "MenuProdutos";
            this.Size = new System.Drawing.Size(824, 448);
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Prod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Prod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Edit_Prod;
        private System.Windows.Forms.PictureBox Add_Prod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
    }
}
