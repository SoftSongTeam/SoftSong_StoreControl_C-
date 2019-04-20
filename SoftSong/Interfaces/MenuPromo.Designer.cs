namespace SoftSong.Interfaces
{
    partial class MenuPromo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPromo));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Remove_Promo = new System.Windows.Forms.PictureBox();
            this.Add_Promo = new System.Windows.Forms.PictureBox();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Remove_Promo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Promo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(535, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "Editar Funcionarios";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(111, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "Adicionar Produtos";
            // 
            // Remove_Promo
            // 
            this.Remove_Promo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PanelAnimator.SetDecoration(this.Remove_Promo, BunifuAnimatorNS.DecorationType.None);
            this.Remove_Promo.Image = ((System.Drawing.Image)(resources.GetObject("Remove_Promo.Image")));
            this.Remove_Promo.Location = new System.Drawing.Point(522, 109);
            this.Remove_Promo.Name = "Remove_Promo";
            this.Remove_Promo.Size = new System.Drawing.Size(200, 200);
            this.Remove_Promo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Remove_Promo.TabIndex = 36;
            this.Remove_Promo.TabStop = false;
            this.Remove_Promo.Click += new System.EventHandler(this.Remove_Promo_Click);
            this.Remove_Promo.MouseHover += new System.EventHandler(this.Remove_Promo_MouseHover);
            // 
            // Add_Promo
            // 
            this.Add_Promo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PanelAnimator.SetDecoration(this.Add_Promo, BunifuAnimatorNS.DecorationType.None);
            this.Add_Promo.Image = ((System.Drawing.Image)(resources.GetObject("Add_Promo.Image")));
            this.Add_Promo.Location = new System.Drawing.Point(102, 109);
            this.Add_Promo.Name = "Add_Promo";
            this.Add_Promo.Size = new System.Drawing.Size(200, 200);
            this.Add_Promo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Add_Promo.TabIndex = 35;
            this.Add_Promo.TabStop = false;
            this.Add_Promo.Click += new System.EventHandler(this.Add_Promo_Click);
            this.Add_Promo.MouseHover += new System.EventHandler(this.Add_Promo_MouseHover);
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
            // MenuPromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Remove_Promo);
            this.Controls.Add(this.Add_Promo);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "MenuPromo";
            this.Size = new System.Drawing.Size(824, 448);
            ((System.ComponentModel.ISupportInitialize)(this.Remove_Promo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Promo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Remove_Promo;
        private System.Windows.Forms.PictureBox Add_Promo;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
    }
}
