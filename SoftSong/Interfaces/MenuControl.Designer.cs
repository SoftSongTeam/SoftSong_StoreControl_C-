namespace SoftSong.Interfaces
{
    partial class MenuControl
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuControl));
            this.Add_Cli = new System.Windows.Forms.PictureBox();
            this.Add_Fun = new System.Windows.Forms.PictureBox();
            this.Add_Forn = new System.Windows.Forms.PictureBox();
            this.Add_Trans = new System.Windows.Forms.PictureBox();
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.lbl_Items = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Edit_Cli = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Edit_Fun = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Edit_Trans = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Edit_Forn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Cli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Fun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Forn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Trans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Cli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Fun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Trans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Forn)).BeginInit();
            this.SuspendLayout();
            // 
            // Add_Cli
            // 
            this.Add_Cli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PanelAnimator.SetDecoration(this.Add_Cli, BunifuAnimatorNS.DecorationType.None);
            this.Add_Cli.Image = ((System.Drawing.Image)(resources.GetObject("Add_Cli.Image")));
            this.Add_Cli.Location = new System.Drawing.Point(62, 33);
            this.Add_Cli.Name = "Add_Cli";
            this.Add_Cli.Size = new System.Drawing.Size(127, 110);
            this.Add_Cli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Add_Cli.TabIndex = 0;
            this.Add_Cli.TabStop = false;
            this.Add_Cli.Click += new System.EventHandler(this.Add_Cli_Click);
            this.Add_Cli.MouseHover += new System.EventHandler(this.Add_Cli_MouseHover);
            // 
            // Add_Fun
            // 
            this.Add_Fun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PanelAnimator.SetDecoration(this.Add_Fun, BunifuAnimatorNS.DecorationType.None);
            this.Add_Fun.Image = ((System.Drawing.Image)(resources.GetObject("Add_Fun.Image")));
            this.Add_Fun.Location = new System.Drawing.Point(252, 33);
            this.Add_Fun.Name = "Add_Fun";
            this.Add_Fun.Size = new System.Drawing.Size(127, 110);
            this.Add_Fun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Add_Fun.TabIndex = 1;
            this.Add_Fun.TabStop = false;
            this.Add_Fun.Click += new System.EventHandler(this.Add_Fun_Click);
            this.Add_Fun.MouseHover += new System.EventHandler(this.Add_Fun_MouseHover);
            // 
            // Add_Forn
            // 
            this.Add_Forn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PanelAnimator.SetDecoration(this.Add_Forn, BunifuAnimatorNS.DecorationType.None);
            this.Add_Forn.Image = ((System.Drawing.Image)(resources.GetObject("Add_Forn.Image")));
            this.Add_Forn.Location = new System.Drawing.Point(443, 33);
            this.Add_Forn.Name = "Add_Forn";
            this.Add_Forn.Size = new System.Drawing.Size(127, 110);
            this.Add_Forn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Add_Forn.TabIndex = 2;
            this.Add_Forn.TabStop = false;
            this.Add_Forn.Click += new System.EventHandler(this.Add_Forn_Click);
            this.Add_Forn.MouseHover += new System.EventHandler(this.Add_Forn_MouseHover);
            // 
            // Add_Trans
            // 
            this.Add_Trans.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PanelAnimator.SetDecoration(this.Add_Trans, BunifuAnimatorNS.DecorationType.None);
            this.Add_Trans.Image = ((System.Drawing.Image)(resources.GetObject("Add_Trans.Image")));
            this.Add_Trans.Location = new System.Drawing.Point(633, 33);
            this.Add_Trans.Name = "Add_Trans";
            this.Add_Trans.Size = new System.Drawing.Size(127, 110);
            this.Add_Trans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Add_Trans.TabIndex = 3;
            this.Add_Trans.TabStop = false;
            this.Add_Trans.Click += new System.EventHandler(this.Add_Trans_Click);
            this.Add_Trans.MouseHover += new System.EventHandler(this.Add_Trans_MouseHover);
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.PanelAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.PanelAnimator.DefaultAnimation = animation1;
            this.PanelAnimator.TimeStep = 0.01F;
            // 
            // lbl_Items
            // 
            this.lbl_Items.AutoSize = true;
            this.lbl_Items.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.lbl_Items, BunifuAnimatorNS.DecorationType.None);
            this.lbl_Items.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Items.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Items.Location = new System.Drawing.Point(51, 148);
            this.lbl_Items.Name = "lbl_Items";
            this.lbl_Items.Size = new System.Drawing.Size(152, 21);
            this.lbl_Items.TabIndex = 24;
            this.lbl_Items.Text = "Adicionar Clientes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(220, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Adicionar Funcionarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(418, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Adicionar Fornecedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(597, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Adicionar Transportadora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(64, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Editar Clientes";
            // 
            // Edit_Cli
            // 
            this.Edit_Cli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PanelAnimator.SetDecoration(this.Edit_Cli, BunifuAnimatorNS.DecorationType.None);
            this.Edit_Cli.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Cli.Image")));
            this.Edit_Cli.Location = new System.Drawing.Point(62, 264);
            this.Edit_Cli.Name = "Edit_Cli";
            this.Edit_Cli.Size = new System.Drawing.Size(127, 110);
            this.Edit_Cli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Edit_Cli.TabIndex = 28;
            this.Edit_Cli.TabStop = false;
            this.Edit_Cli.Click += new System.EventHandler(this.Edit_Cli_Click);
            this.Edit_Cli.MouseHover += new System.EventHandler(this.Edit_Cli_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(237, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 21);
            this.label5.TabIndex = 31;
            this.label5.Text = "Editar Funcionarios";
            // 
            // Edit_Fun
            // 
            this.Edit_Fun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PanelAnimator.SetDecoration(this.Edit_Fun, BunifuAnimatorNS.DecorationType.None);
            this.Edit_Fun.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Fun.Image")));
            this.Edit_Fun.Location = new System.Drawing.Point(252, 264);
            this.Edit_Fun.Name = "Edit_Fun";
            this.Edit_Fun.Size = new System.Drawing.Size(127, 110);
            this.Edit_Fun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Edit_Fun.TabIndex = 30;
            this.Edit_Fun.TabStop = false;
            this.Edit_Fun.Click += new System.EventHandler(this.Edit_Fun_Click);
            this.Edit_Fun.MouseHover += new System.EventHandler(this.Edit_Fun_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(606, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "Editar Transportadora";
            // 
            // Edit_Trans
            // 
            this.PanelAnimator.SetDecoration(this.Edit_Trans, BunifuAnimatorNS.DecorationType.None);
            this.Edit_Trans.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Trans.Image")));
            this.Edit_Trans.Location = new System.Drawing.Point(633, 264);
            this.Edit_Trans.Name = "Edit_Trans";
            this.Edit_Trans.Size = new System.Drawing.Size(127, 110);
            this.Edit_Trans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Edit_Trans.TabIndex = 32;
            this.Edit_Trans.TabStop = false;
            this.Edit_Trans.Click += new System.EventHandler(this.Edit_Trans_Click);
            this.Edit_Trans.MouseHover += new System.EventHandler(this.Edit_Trans_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.PanelAnimator.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(432, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 21);
            this.label7.TabIndex = 35;
            this.label7.Text = "Editar Fornecedor";
            // 
            // Edit_Forn
            // 
            this.Edit_Forn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.PanelAnimator.SetDecoration(this.Edit_Forn, BunifuAnimatorNS.DecorationType.None);
            this.Edit_Forn.Image = ((System.Drawing.Image)(resources.GetObject("Edit_Forn.Image")));
            this.Edit_Forn.Location = new System.Drawing.Point(443, 264);
            this.Edit_Forn.Name = "Edit_Forn";
            this.Edit_Forn.Size = new System.Drawing.Size(127, 110);
            this.Edit_Forn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Edit_Forn.TabIndex = 34;
            this.Edit_Forn.TabStop = false;
            this.Edit_Forn.Click += new System.EventHandler(this.Edit_Forn_Click);
            this.Edit_Forn.MouseHover += new System.EventHandler(this.Edit_Forn_MouseHover);
            // 
            // MenuControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Edit_Forn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Edit_Trans);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Edit_Fun);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Edit_Cli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Items);
            this.Controls.Add(this.Add_Trans);
            this.Controls.Add(this.Add_Forn);
            this.Controls.Add(this.Add_Fun);
            this.Controls.Add(this.Add_Cli);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "MenuControl";
            this.Size = new System.Drawing.Size(824, 448);
            ((System.ComponentModel.ISupportInitialize)(this.Add_Cli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Fun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Forn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Trans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Cli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Fun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Trans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_Forn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Add_Cli;
        private System.Windows.Forms.PictureBox Add_Fun;
        private System.Windows.Forms.PictureBox Add_Forn;
        private System.Windows.Forms.PictureBox Add_Trans;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private System.Windows.Forms.Label lbl_Items;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Edit_Cli;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Edit_Fun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox Edit_Trans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox Edit_Forn;
    }
}
