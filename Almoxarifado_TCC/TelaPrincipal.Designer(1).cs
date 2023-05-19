namespace Almoxarifado_TCC
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconStatus = new FontAwesome.Sharp.IconButton();
            this.lblNome = new System.Windows.Forms.Label();
            this.panelLine2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelFotoUsuario = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelSubMenuEstoque = new System.Windows.Forms.Panel();
            this.btnEstoqueHist = new FontAwesome.Sharp.IconButton();
            this.btnDescarte = new FontAwesome.Sharp.IconButton();
            this.btnEstoque = new FontAwesome.Sharp.IconButton();
            this.panelSubMenuChave = new System.Windows.Forms.Panel();
            this.btnChaveHist = new FontAwesome.Sharp.IconButton();
            this.btnChave = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnFullSC = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.lblCurrentChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelTitleRepart = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelFotoUsuario.SuspendLayout();
            this.panelSubMenuEstoque.SuspendLayout();
            this.panelSubMenuChave.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panelSubMenuEstoque);
            this.panelMenu.Controls.Add(this.btnEstoque);
            this.panelMenu.Controls.Add(this.panelSubMenuChave);
            this.panelMenu.Controls.Add(this.btnChave);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 749);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iconStatus);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.panelLine2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelFotoUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 670);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 79);
            this.panel1.TabIndex = 5;
            // 
            // iconStatus
            // 
            this.iconStatus.FlatAppearance.BorderSize = 0;
            this.iconStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconStatus.IconChar = FontAwesome.Sharp.IconChar.CircleChevronDown;
            this.iconStatus.IconColor = System.Drawing.Color.ForestGreen;
            this.iconStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconStatus.IconSize = 15;
            this.iconStatus.Location = new System.Drawing.Point(65, 49);
            this.iconStatus.Name = "iconStatus";
            this.iconStatus.Size = new System.Drawing.Size(15, 15);
            this.iconStatus.TabIndex = 6;
            this.iconStatus.UseVisualStyleBackColor = true;
            this.iconStatus.Click += new System.EventHandler(this.iconStatus_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNome.Location = new System.Drawing.Point(66, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 15);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome*";
            // 
            // panelLine2
            // 
            this.panelLine2.ForeColor = System.Drawing.Color.DimGray;
            this.panelLine2.Location = new System.Drawing.Point(9, 9);
            this.panelLine2.Name = "panelLine2";
            this.panelLine2.Size = new System.Drawing.Size(200, 2);
            this.panelLine2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(79, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Status";
            // 
            // panelFotoUsuario
            // 
            this.panelFotoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.panelFotoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelFotoUsuario.Controls.Add(this.button1);
            this.panelFotoUsuario.Location = new System.Drawing.Point(9, 20);
            this.panelFotoUsuario.Name = "panelFotoUsuario";
            this.panelFotoUsuario.Size = new System.Drawing.Size(50, 50);
            this.panelFotoUsuario.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelSubMenuEstoque
            // 
            this.panelSubMenuEstoque.Controls.Add(this.btnEstoqueHist);
            this.panelSubMenuEstoque.Controls.Add(this.btnDescarte);
            this.panelSubMenuEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuEstoque.Location = new System.Drawing.Point(0, 309);
            this.panelSubMenuEstoque.Name = "panelSubMenuEstoque";
            this.panelSubMenuEstoque.Size = new System.Drawing.Size(220, 88);
            this.panelSubMenuEstoque.TabIndex = 4;
            // 
            // btnEstoqueHist
            // 
            this.btnEstoqueHist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstoqueHist.FlatAppearance.BorderSize = 0;
            this.btnEstoqueHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoqueHist.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoqueHist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEstoqueHist.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            this.btnEstoqueHist.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEstoqueHist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEstoqueHist.IconSize = 32;
            this.btnEstoqueHist.Location = new System.Drawing.Point(0, 40);
            this.btnEstoqueHist.Name = "btnEstoqueHist";
            this.btnEstoqueHist.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEstoqueHist.Size = new System.Drawing.Size(220, 40);
            this.btnEstoqueHist.TabIndex = 4;
            this.btnEstoqueHist.Text = "Histórico";
            this.btnEstoqueHist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoqueHist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstoqueHist.UseVisualStyleBackColor = true;
            this.btnEstoqueHist.Click += new System.EventHandler(this.btnEstoqueHist_Click);
            // 
            // btnDescarte
            // 
            this.btnDescarte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDescarte.FlatAppearance.BorderSize = 0;
            this.btnDescarte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescarte.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescarte.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDescarte.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.btnDescarte.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDescarte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDescarte.IconSize = 32;
            this.btnDescarte.Location = new System.Drawing.Point(0, 0);
            this.btnDescarte.Name = "btnDescarte";
            this.btnDescarte.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDescarte.Size = new System.Drawing.Size(220, 40);
            this.btnDescarte.TabIndex = 3;
            this.btnDescarte.Text = "Descartes";
            this.btnDescarte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescarte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDescarte.UseVisualStyleBackColor = true;
            this.btnDescarte.Click += new System.EventHandler(this.btnDescarte_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEstoque.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnEstoque.IconColor = System.Drawing.Color.Gainsboro;
            this.btnEstoque.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEstoque.IconSize = 32;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(0, 249);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEstoque.Size = new System.Drawing.Size(220, 60);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // panelSubMenuChave
            // 
            this.panelSubMenuChave.Controls.Add(this.btnChaveHist);
            this.panelSubMenuChave.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuChave.Location = new System.Drawing.Point(0, 200);
            this.panelSubMenuChave.Name = "panelSubMenuChave";
            this.panelSubMenuChave.Size = new System.Drawing.Size(220, 49);
            this.panelSubMenuChave.TabIndex = 3;
            // 
            // btnChaveHist
            // 
            this.btnChaveHist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChaveHist.FlatAppearance.BorderSize = 0;
            this.btnChaveHist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChaveHist.Font = new System.Drawing.Font("Candara", 9.75F);
            this.btnChaveHist.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnChaveHist.IconChar = FontAwesome.Sharp.IconChar.ClockRotateLeft;
            this.btnChaveHist.IconColor = System.Drawing.Color.Gainsboro;
            this.btnChaveHist.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChaveHist.IconSize = 32;
            this.btnChaveHist.Location = new System.Drawing.Point(0, 0);
            this.btnChaveHist.Name = "btnChaveHist";
            this.btnChaveHist.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnChaveHist.Size = new System.Drawing.Size(220, 40);
            this.btnChaveHist.TabIndex = 2;
            this.btnChaveHist.Text = "Pedidos";
            this.btnChaveHist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChaveHist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChaveHist.UseVisualStyleBackColor = true;
            this.btnChaveHist.Click += new System.EventHandler(this.btnChaveHist_Click);
            // 
            // btnChave
            // 
            this.btnChave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChave.FlatAppearance.BorderSize = 0;
            this.btnChave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChave.Font = new System.Drawing.Font("Candara", 9.75F);
            this.btnChave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnChave.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnChave.IconColor = System.Drawing.Color.Gainsboro;
            this.btnChave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChave.IconSize = 32;
            this.btnChave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChave.Location = new System.Drawing.Point(0, 140);
            this.btnChave.Name = "btnChave";
            this.btnChave.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnChave.Size = new System.Drawing.Size(220, 60);
            this.btnChave.TabIndex = 1;
            this.btnChave.Text = "Chave";
            this.btnChave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChave.UseVisualStyleBackColor = true;
            this.btnChave.Click += new System.EventHandler(this.btnChave_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(9, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(201, 116);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnFullSC);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(788, 70);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(713, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnFullSC
            // 
            this.btnFullSC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFullSC.FlatAppearance.BorderSize = 0;
            this.btnFullSC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullSC.ForeColor = System.Drawing.Color.Transparent;
            this.btnFullSC.IconChar = FontAwesome.Sharp.IconChar.Expand;
            this.btnFullSC.IconColor = System.Drawing.Color.White;
            this.btnFullSC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFullSC.IconSize = 20;
            this.btnFullSC.Location = new System.Drawing.Point(739, 3);
            this.btnFullSC.Name = "btnFullSC";
            this.btnFullSC.Size = new System.Drawing.Size(20, 20);
            this.btnFullSC.TabIndex = 3;
            this.btnFullSC.UseVisualStyleBackColor = true;
            this.btnFullSC.Click += new System.EventHandler(this.btnFullSC_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(765, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCurrentChildForm
            // 
            this.lblCurrentChildForm.AutoSize = true;
            this.lblCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentChildForm.Font = new System.Drawing.Font("Candara", 9.75F);
            this.lblCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCurrentChildForm.Location = new System.Drawing.Point(54, 26);
            this.lblCurrentChildForm.Name = "lblCurrentChildForm";
            this.lblCurrentChildForm.Size = new System.Drawing.Size(39, 15);
            this.lblCurrentChildForm.TabIndex = 1;
            this.lblCurrentChildForm.Text = "Menu";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(16, 18);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelTitleRepart
            // 
            this.panelTitleRepart.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleRepart.Location = new System.Drawing.Point(220, 70);
            this.panelTitleRepart.Name = "panelTitleRepart";
            this.panelTitleRepart.Size = new System.Drawing.Size(788, 5);
            this.panelTitleRepart.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelDesktop.Controls.Add(this.lblData);
            this.panelDesktop.Controls.Add(this.lblTimer);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(788, 674);
            this.panelDesktop.TabIndex = 3;
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(148)))));
            this.lblData.Location = new System.Drawing.Point(277, 464);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(225, 25);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "dddd, MMM dd yyyy";
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(148)))));
            this.lblTimer.Location = new System.Drawing.Point(329, 423);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(158, 41);
            this.lblTimer.TabIndex = 2;
            this.lblTimer.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 238);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1008, 749);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleRepart);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 766);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelFotoUsuario.ResumeLayout(false);
            this.panelSubMenuEstoque.ResumeLayout(false);
            this.panelSubMenuChave.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnChave;
        private FontAwesome.Sharp.IconButton btnEstoque;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblCurrentChildForm;
        private System.Windows.Forms.Panel panelTitleRepart;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnFullSC;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panelSubMenuEstoque;
        private FontAwesome.Sharp.IconButton btnEstoqueHist;
        private FontAwesome.Sharp.IconButton btnDescarte;
        private System.Windows.Forms.Panel panelSubMenuChave;
        private FontAwesome.Sharp.IconButton btnChaveHist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFotoUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelLine2;
        private System.Windows.Forms.Button button1;
        private FontAwesome.Sharp.IconButton iconStatus;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblData;
    }
}