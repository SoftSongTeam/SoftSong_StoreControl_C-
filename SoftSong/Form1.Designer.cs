namespace SoftSong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.sideMenu = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lilnote = new System.Windows.Forms.PictureBox();
            this.btn_Gerenciar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Cadastros = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Home = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.LogoAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.PanelAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.sideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lilnote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.PanelAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 32);
            this.panel1.TabIndex = 0;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.PanelAnimator.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuImageButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(851, 2);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(26, 28);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 1;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 20;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.PanelAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(879, 2);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(26, 28);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 0;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 20;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.sideMenu.Controls.Add(this.bunifuFlatButton1);
            this.sideMenu.Controls.Add(this.lilnote);
            this.sideMenu.Controls.Add(this.btn_Gerenciar);
            this.sideMenu.Controls.Add(this.btn_Cadastros);
            this.sideMenu.Controls.Add(this.btn_Home);
            this.sideMenu.Controls.Add(this.bunifuImageButton1);
            this.sideMenu.Controls.Add(this.Logo);
            this.PanelAnimator.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.sideMenu, BunifuAnimatorNS.DecorationType.None);
            this.sideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenu.Location = new System.Drawing.Point(0, 32);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(44, 492);
            this.sideMenu.TabIndex = 1;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Gerenciar Promoções";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 80D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(2, 268);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(246, 41);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.Text = "Gerenciar Promoções";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // lilnote
            // 
            this.LogoAnimator.SetDecoration(this.lilnote, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.lilnote, BunifuAnimatorNS.DecorationType.None);
            this.lilnote.Image = ((System.Drawing.Image)(resources.GetObject("lilnote.Image")));
            this.lilnote.Location = new System.Drawing.Point(7, 52);
            this.lilnote.Name = "lilnote";
            this.lilnote.Size = new System.Drawing.Size(28, 50);
            this.lilnote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lilnote.TabIndex = 5;
            this.lilnote.TabStop = false;
            this.lilnote.Visible = false;
            // 
            // btn_Gerenciar
            // 
            this.btn_Gerenciar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_Gerenciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_Gerenciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Gerenciar.BorderRadius = 0;
            this.btn_Gerenciar.ButtonText = "Gerenciar Instrumentos";
            this.btn_Gerenciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btn_Gerenciar, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btn_Gerenciar, BunifuAnimatorNS.DecorationType.None);
            this.btn_Gerenciar.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Gerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gerenciar.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Gerenciar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Gerenciar.Iconimage")));
            this.btn_Gerenciar.Iconimage_right = null;
            this.btn_Gerenciar.Iconimage_right_Selected = null;
            this.btn_Gerenciar.Iconimage_Selected = null;
            this.btn_Gerenciar.IconMarginLeft = 0;
            this.btn_Gerenciar.IconMarginRight = 0;
            this.btn_Gerenciar.IconRightVisible = true;
            this.btn_Gerenciar.IconRightZoom = 0D;
            this.btn_Gerenciar.IconVisible = true;
            this.btn_Gerenciar.IconZoom = 80D;
            this.btn_Gerenciar.IsTab = true;
            this.btn_Gerenciar.Location = new System.Drawing.Point(1, 222);
            this.btn_Gerenciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Gerenciar.Name = "btn_Gerenciar";
            this.btn_Gerenciar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_Gerenciar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_Gerenciar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btn_Gerenciar.selected = false;
            this.btn_Gerenciar.Size = new System.Drawing.Size(246, 41);
            this.btn_Gerenciar.TabIndex = 4;
            this.btn_Gerenciar.Text = "Gerenciar Instrumentos";
            this.btn_Gerenciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Gerenciar.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Gerenciar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Gerenciar.Click += new System.EventHandler(this.btn_Gerenciar_Click);
            // 
            // btn_Cadastros
            // 
            this.btn_Cadastros.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_Cadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_Cadastros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cadastros.BorderRadius = 0;
            this.btn_Cadastros.ButtonText = "          Gerenciar Cadastros";
            this.btn_Cadastros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btn_Cadastros, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btn_Cadastros, BunifuAnimatorNS.DecorationType.None);
            this.btn_Cadastros.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Cadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastros.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Cadastros.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Cadastros.Iconimage")));
            this.btn_Cadastros.Iconimage_right = null;
            this.btn_Cadastros.Iconimage_right_Selected = null;
            this.btn_Cadastros.Iconimage_Selected = null;
            this.btn_Cadastros.IconMarginLeft = 0;
            this.btn_Cadastros.IconMarginRight = 0;
            this.btn_Cadastros.IconRightVisible = true;
            this.btn_Cadastros.IconRightZoom = 0D;
            this.btn_Cadastros.IconVisible = true;
            this.btn_Cadastros.IconZoom = 80D;
            this.btn_Cadastros.IsTab = true;
            this.btn_Cadastros.Location = new System.Drawing.Point(1, 178);
            this.btn_Cadastros.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cadastros.Name = "btn_Cadastros";
            this.btn_Cadastros.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_Cadastros.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_Cadastros.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btn_Cadastros.selected = false;
            this.btn_Cadastros.Size = new System.Drawing.Size(246, 41);
            this.btn_Cadastros.TabIndex = 3;
            this.btn_Cadastros.Text = "          Gerenciar Cadastros";
            this.btn_Cadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cadastros.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cadastros.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cadastros.Click += new System.EventHandler(this.btn_Cadastros_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Home.BorderRadius = 0;
            this.btn_Home.ButtonText = "                      Home";
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PanelAnimator.SetDecoration(this.btn_Home, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.btn_Home, BunifuAnimatorNS.DecorationType.None);
            this.btn_Home.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Home.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Home.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Home.Iconimage")));
            this.btn_Home.Iconimage_right = null;
            this.btn_Home.Iconimage_right_Selected = null;
            this.btn_Home.Iconimage_Selected = null;
            this.btn_Home.IconMarginLeft = 0;
            this.btn_Home.IconMarginRight = 0;
            this.btn_Home.IconRightVisible = true;
            this.btn_Home.IconRightZoom = 0D;
            this.btn_Home.IconVisible = true;
            this.btn_Home.IconZoom = 80D;
            this.btn_Home.IsTab = true;
            this.btn_Home.Location = new System.Drawing.Point(1, 135);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_Home.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btn_Home.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btn_Home.selected = true;
            this.btn_Home.Size = new System.Drawing.Size(251, 41);
            this.btn_Home.TabIndex = 2;
            this.btn_Home.Text = "                      Home";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.btn_Home.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.PanelAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.LogoAnimator.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(0, 0);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(44, 27);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Logo
            // 
            this.LogoAnimator.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(74, 32);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(103, 91);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // LogoAnimator
            // 
            this.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.LogoAnimator.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 0;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0.5F;
            animation4.RotateLimit = 0.2F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.LogoAnimator.DefaultAnimation = animation4;
            this.LogoAnimator.TimeStep = 0.015F;
            // 
            // PanelAnimator
            // 
            this.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.PanelAnimator.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 1F;
            this.PanelAnimator.DefaultAnimation = animation3;
            this.PanelAnimator.TimeStep = 0.01F;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(910, 524);
            this.Controls.Add(this.sideMenu);
            this.Controls.Add(this.panel1);
            this.LogoAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.PanelAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.sideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lilnote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sideMenu;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.PictureBox Logo;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Gerenciar;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Cadastros;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Home;
        private BunifuAnimatorNS.BunifuTransition PanelAnimator;
        private BunifuAnimatorNS.BunifuTransition LogoAnimator;
        private System.Windows.Forms.PictureBox lilnote;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Timer timer1;
    }
}