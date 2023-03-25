namespace DRPC
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TopPanel = new Siticone.UI.WinForms.SiticonePanel();
            this.LogoPicture = new Siticone.UI.WinForms.SiticonePictureBox();
            this.CloseImageButton = new Siticone.UI.WinForms.SiticoneImageButton();
            this.MinimizeImageButton = new Siticone.UI.WinForms.SiticoneImageButton();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ElipseForm = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.DragTopPanel = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.DragHaloxxLogo = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.DragNameLabel = new Siticone.UI.WinForms.SiticoneTransparentDrag();
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.AppIdTBox = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.siticoneLabel2 = new Siticone.UI.WinForms.SiticoneLabel();
            this.StateTBox = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.siticoneLabel3 = new Siticone.UI.WinForms.SiticoneLabel();
            this.DetailsTBox = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.siticoneLabel4 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel5 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel6 = new Siticone.UI.WinForms.SiticoneLabel();
            this.LImgTBox = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.LImgTextTBox = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.SImgTBox = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.siticoneLabel7 = new Siticone.UI.WinForms.SiticoneLabel();
            this.SImgTextTBox = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.PartySize1 = new Siticone.UI.WinForms.SiticoneNumericUpDown();
            this.PartySize2 = new Siticone.UI.WinForms.SiticoneNumericUpDown();
            this.siticoneLabel8 = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneLabel9 = new Siticone.UI.WinForms.SiticoneLabel();
            this.ActivateButton = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneShadowForm1 = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.InjectButton = new Siticone.UI.WinForms.SiticoneButton();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartySize1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartySize2)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TopPanel.Controls.Add(this.LogoPicture);
            this.TopPanel.Controls.Add(this.CloseImageButton);
            this.TopPanel.Controls.Add(this.MinimizeImageButton);
            this.TopPanel.Controls.Add(this.NameLabel);
            this.TopPanel.Location = new System.Drawing.Point(-2, -5);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShadowDecoration.BorderRadius = 5;
            this.TopPanel.ShadowDecoration.Depth = 8;
            this.TopPanel.ShadowDecoration.Enabled = true;
            this.TopPanel.ShadowDecoration.Parent = this.TopPanel;
            this.TopPanel.Size = new System.Drawing.Size(789, 68);
            this.TopPanel.TabIndex = 0;
            // 
            // LogoPicture
            // 
            this.LogoPicture.BackColor = System.Drawing.Color.Transparent;
            this.LogoPicture.Image = global::DRPC.Properties.Resources.haloxx_logo_no_background;
            this.LogoPicture.Location = new System.Drawing.Point(3, 6);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.ShadowDecoration.Parent = this.LogoPicture;
            this.LogoPicture.Size = new System.Drawing.Size(98, 65);
            this.LogoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPicture.TabIndex = 1;
            this.LogoPicture.TabStop = false;
            // 
            // CloseImageButton
            // 
            this.CloseImageButton.CheckedState.Parent = this.CloseImageButton;
            this.CloseImageButton.HoveredState.ImageSize = new System.Drawing.Size(30, 30);
            this.CloseImageButton.HoveredState.Parent = this.CloseImageButton;
            this.CloseImageButton.Image = global::DRPC.Properties.Resources.close;
            this.CloseImageButton.ImageSize = new System.Drawing.Size(30, 30);
            this.CloseImageButton.Location = new System.Drawing.Point(744, 22);
            this.CloseImageButton.Name = "CloseImageButton";
            this.CloseImageButton.PressedState.Parent = this.CloseImageButton;
            this.CloseImageButton.Size = new System.Drawing.Size(30, 30);
            this.CloseImageButton.TabIndex = 3;
            this.CloseImageButton.Click += new System.EventHandler(this.CloseImageButton_Click);
            // 
            // MinimizeImageButton
            // 
            this.MinimizeImageButton.CheckedState.Parent = this.MinimizeImageButton;
            this.MinimizeImageButton.HoveredState.ImageSize = new System.Drawing.Size(30, 30);
            this.MinimizeImageButton.HoveredState.Parent = this.MinimizeImageButton;
            this.MinimizeImageButton.Image = global::DRPC.Properties.Resources.minimize;
            this.MinimizeImageButton.ImageSize = new System.Drawing.Size(30, 30);
            this.MinimizeImageButton.Location = new System.Drawing.Point(707, 22);
            this.MinimizeImageButton.Name = "MinimizeImageButton";
            this.MinimizeImageButton.PressedState.Parent = this.MinimizeImageButton;
            this.MinimizeImageButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeImageButton.TabIndex = 3;
            this.MinimizeImageButton.Click += new System.EventHandler(this.MinimizeImageButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Gotham", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(277, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(236, 39);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "DiscordRPC";
            // 
            // ElipseForm
            // 
            this.ElipseForm.TargetControl = this;
            // 
            // DragTopPanel
            // 
            this.DragTopPanel.DragEndTransparencyValue = 1D;
            this.DragTopPanel.DragStartTransparencyValue = 0.9D;
            this.DragTopPanel.TargetDragControl = this.TopPanel;
            // 
            // DragHaloxxLogo
            // 
            this.DragHaloxxLogo.DragEndTransparencyValue = 1D;
            this.DragHaloxxLogo.DragStartTransparencyValue = 0.9D;
            this.DragHaloxxLogo.TargetDragControl = this.LogoPicture;
            // 
            // DragNameLabel
            // 
            this.DragNameLabel.DragEndTransparencyValue = 1D;
            this.DragNameLabel.DragStartTransparencyValue = 0.9D;
            this.DragNameLabel.TargetDragControl = this.NameLabel;
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.siticoneLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel1.Location = new System.Drawing.Point(84, 105);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(111, 23);
            this.siticoneLabel1.TabIndex = 3;
            this.siticoneLabel1.Text = "Application ID";
            // 
            // AppIdTBox
            // 
            this.AppIdTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.AppIdTBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.AppIdTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AppIdTBox.DefaultText = "";
            this.AppIdTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AppIdTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AppIdTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AppIdTBox.DisabledState.Parent = this.AppIdTBox;
            this.AppIdTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AppIdTBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.AppIdTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AppIdTBox.FocusedState.Parent = this.AppIdTBox;
            this.AppIdTBox.ForeColor = System.Drawing.Color.White;
            this.AppIdTBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AppIdTBox.HoveredState.Parent = this.AppIdTBox;
            this.AppIdTBox.Location = new System.Drawing.Point(39, 134);
            this.AppIdTBox.Name = "AppIdTBox";
            this.AppIdTBox.PasswordChar = '\0';
            this.AppIdTBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.AppIdTBox.PlaceholderText = "";
            this.AppIdTBox.SelectedText = "";
            this.AppIdTBox.ShadowDecoration.BorderRadius = 3;
            this.AppIdTBox.ShadowDecoration.Depth = 10;
            this.AppIdTBox.ShadowDecoration.Enabled = true;
            this.AppIdTBox.ShadowDecoration.Parent = this.AppIdTBox;
            this.AppIdTBox.Size = new System.Drawing.Size(200, 36);
            this.AppIdTBox.TabIndex = 4;
            this.AppIdTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneLabel2
            // 
            this.siticoneLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.siticoneLabel2.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel2.Location = new System.Drawing.Point(372, 105);
            this.siticoneLabel2.Name = "siticoneLabel2";
            this.siticoneLabel2.Size = new System.Drawing.Size(42, 23);
            this.siticoneLabel2.TabIndex = 3;
            this.siticoneLabel2.Text = "State";
            // 
            // StateTBox
            // 
            this.StateTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.StateTBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.StateTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StateTBox.DefaultText = "";
            this.StateTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StateTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StateTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StateTBox.DisabledState.Parent = this.StateTBox;
            this.StateTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StateTBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.StateTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StateTBox.FocusedState.Parent = this.StateTBox;
            this.StateTBox.ForeColor = System.Drawing.Color.White;
            this.StateTBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StateTBox.HoveredState.Parent = this.StateTBox;
            this.StateTBox.Location = new System.Drawing.Point(291, 134);
            this.StateTBox.Name = "StateTBox";
            this.StateTBox.PasswordChar = '\0';
            this.StateTBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.StateTBox.PlaceholderText = "";
            this.StateTBox.SelectedText = "";
            this.StateTBox.ShadowDecoration.BorderRadius = 3;
            this.StateTBox.ShadowDecoration.Depth = 10;
            this.StateTBox.ShadowDecoration.Enabled = true;
            this.StateTBox.ShadowDecoration.Parent = this.StateTBox;
            this.StateTBox.Size = new System.Drawing.Size(200, 36);
            this.StateTBox.TabIndex = 4;
            this.StateTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneLabel3
            // 
            this.siticoneLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.siticoneLabel3.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel3.Location = new System.Drawing.Point(614, 105);
            this.siticoneLabel3.Name = "siticoneLabel3";
            this.siticoneLabel3.Size = new System.Drawing.Size(54, 23);
            this.siticoneLabel3.TabIndex = 3;
            this.siticoneLabel3.Text = "Details";
            // 
            // DetailsTBox
            // 
            this.DetailsTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.DetailsTBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DetailsTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DetailsTBox.DefaultText = "";
            this.DetailsTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.DetailsTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.DetailsTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DetailsTBox.DisabledState.Parent = this.DetailsTBox;
            this.DetailsTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.DetailsTBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DetailsTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DetailsTBox.FocusedState.Parent = this.DetailsTBox;
            this.DetailsTBox.ForeColor = System.Drawing.Color.White;
            this.DetailsTBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DetailsTBox.HoveredState.Parent = this.DetailsTBox;
            this.DetailsTBox.Location = new System.Drawing.Point(539, 134);
            this.DetailsTBox.Name = "DetailsTBox";
            this.DetailsTBox.PasswordChar = '\0';
            this.DetailsTBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.DetailsTBox.PlaceholderText = "";
            this.DetailsTBox.SelectedText = "";
            this.DetailsTBox.ShadowDecoration.BorderRadius = 3;
            this.DetailsTBox.ShadowDecoration.Depth = 10;
            this.DetailsTBox.ShadowDecoration.Enabled = true;
            this.DetailsTBox.ShadowDecoration.Parent = this.DetailsTBox;
            this.DetailsTBox.Size = new System.Drawing.Size(200, 36);
            this.DetailsTBox.TabIndex = 4;
            this.DetailsTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneLabel4
            // 
            this.siticoneLabel4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.siticoneLabel4.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel4.Location = new System.Drawing.Point(91, 189);
            this.siticoneLabel4.Name = "siticoneLabel4";
            this.siticoneLabel4.Size = new System.Drawing.Size(98, 23);
            this.siticoneLabel4.TabIndex = 3;
            this.siticoneLabel4.Text = "Large Image";
            // 
            // siticoneLabel5
            // 
            this.siticoneLabel5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.siticoneLabel5.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel5.Location = new System.Drawing.Point(327, 189);
            this.siticoneLabel5.Name = "siticoneLabel5";
            this.siticoneLabel5.Size = new System.Drawing.Size(135, 23);
            this.siticoneLabel5.TabIndex = 3;
            this.siticoneLabel5.Text = "Large Image Text";
            // 
            // siticoneLabel6
            // 
            this.siticoneLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.siticoneLabel6.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel6.Location = new System.Drawing.Point(597, 189);
            this.siticoneLabel6.Name = "siticoneLabel6";
            this.siticoneLabel6.Size = new System.Drawing.Size(97, 23);
            this.siticoneLabel6.TabIndex = 3;
            this.siticoneLabel6.Text = "Small Image";
            // 
            // LImgTBox
            // 
            this.LImgTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.LImgTBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LImgTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LImgTBox.DefaultText = "";
            this.LImgTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LImgTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LImgTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LImgTBox.DisabledState.Parent = this.LImgTBox;
            this.LImgTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LImgTBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LImgTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LImgTBox.FocusedState.Parent = this.LImgTBox;
            this.LImgTBox.ForeColor = System.Drawing.Color.White;
            this.LImgTBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LImgTBox.HoveredState.Parent = this.LImgTBox;
            this.LImgTBox.Location = new System.Drawing.Point(39, 218);
            this.LImgTBox.Name = "LImgTBox";
            this.LImgTBox.PasswordChar = '\0';
            this.LImgTBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.LImgTBox.PlaceholderText = "";
            this.LImgTBox.SelectedText = "";
            this.LImgTBox.ShadowDecoration.BorderRadius = 3;
            this.LImgTBox.ShadowDecoration.Depth = 10;
            this.LImgTBox.ShadowDecoration.Enabled = true;
            this.LImgTBox.ShadowDecoration.Parent = this.LImgTBox;
            this.LImgTBox.Size = new System.Drawing.Size(200, 36);
            this.LImgTBox.TabIndex = 4;
            this.LImgTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LImgTextTBox
            // 
            this.LImgTextTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.LImgTextTBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.LImgTextTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LImgTextTBox.DefaultText = "";
            this.LImgTextTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LImgTextTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LImgTextTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LImgTextTBox.DisabledState.Parent = this.LImgTextTBox;
            this.LImgTextTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LImgTextTBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LImgTextTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LImgTextTBox.FocusedState.Parent = this.LImgTextTBox;
            this.LImgTextTBox.ForeColor = System.Drawing.Color.White;
            this.LImgTextTBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LImgTextTBox.HoveredState.Parent = this.LImgTextTBox;
            this.LImgTextTBox.Location = new System.Drawing.Point(291, 218);
            this.LImgTextTBox.Name = "LImgTextTBox";
            this.LImgTextTBox.PasswordChar = '\0';
            this.LImgTextTBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.LImgTextTBox.PlaceholderText = "";
            this.LImgTextTBox.SelectedText = "";
            this.LImgTextTBox.ShadowDecoration.BorderRadius = 3;
            this.LImgTextTBox.ShadowDecoration.Depth = 10;
            this.LImgTextTBox.ShadowDecoration.Enabled = true;
            this.LImgTextTBox.ShadowDecoration.Parent = this.LImgTextTBox;
            this.LImgTextTBox.Size = new System.Drawing.Size(200, 36);
            this.LImgTextTBox.TabIndex = 4;
            this.LImgTextTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SImgTBox
            // 
            this.SImgTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.SImgTBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SImgTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SImgTBox.DefaultText = "";
            this.SImgTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SImgTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SImgTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SImgTBox.DisabledState.Parent = this.SImgTBox;
            this.SImgTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SImgTBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SImgTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SImgTBox.FocusedState.Parent = this.SImgTBox;
            this.SImgTBox.ForeColor = System.Drawing.Color.White;
            this.SImgTBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SImgTBox.HoveredState.Parent = this.SImgTBox;
            this.SImgTBox.Location = new System.Drawing.Point(539, 218);
            this.SImgTBox.Name = "SImgTBox";
            this.SImgTBox.PasswordChar = '\0';
            this.SImgTBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.SImgTBox.PlaceholderText = "";
            this.SImgTBox.SelectedText = "";
            this.SImgTBox.ShadowDecoration.BorderRadius = 3;
            this.SImgTBox.ShadowDecoration.Depth = 10;
            this.SImgTBox.ShadowDecoration.Enabled = true;
            this.SImgTBox.ShadowDecoration.Parent = this.SImgTBox;
            this.SImgTBox.Size = new System.Drawing.Size(200, 36);
            this.SImgTBox.TabIndex = 4;
            this.SImgTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // siticoneLabel7
            // 
            this.siticoneLabel7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel7.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.siticoneLabel7.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel7.Location = new System.Drawing.Point(574, 273);
            this.siticoneLabel7.Name = "siticoneLabel7";
            this.siticoneLabel7.Size = new System.Drawing.Size(134, 23);
            this.siticoneLabel7.TabIndex = 3;
            this.siticoneLabel7.Text = "Small Image Text";
            // 
            // SImgTextTBox
            // 
            this.SImgTextTBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.SImgTextTBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SImgTextTBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SImgTextTBox.DefaultText = "";
            this.SImgTextTBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SImgTextTBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SImgTextTBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SImgTextTBox.DisabledState.Parent = this.SImgTextTBox;
            this.SImgTextTBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SImgTextTBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SImgTextTBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SImgTextTBox.FocusedState.Parent = this.SImgTextTBox;
            this.SImgTextTBox.ForeColor = System.Drawing.Color.White;
            this.SImgTextTBox.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SImgTextTBox.HoveredState.Parent = this.SImgTextTBox;
            this.SImgTextTBox.Location = new System.Drawing.Point(539, 302);
            this.SImgTextTBox.Name = "SImgTextTBox";
            this.SImgTextTBox.PasswordChar = '\0';
            this.SImgTextTBox.PlaceholderForeColor = System.Drawing.Color.White;
            this.SImgTextTBox.PlaceholderText = "";
            this.SImgTextTBox.SelectedText = "";
            this.SImgTextTBox.ShadowDecoration.BorderRadius = 3;
            this.SImgTextTBox.ShadowDecoration.Depth = 10;
            this.SImgTextTBox.ShadowDecoration.Enabled = true;
            this.SImgTextTBox.ShadowDecoration.Parent = this.SImgTextTBox;
            this.SImgTextTBox.Size = new System.Drawing.Size(200, 36);
            this.SImgTextTBox.TabIndex = 4;
            this.SImgTextTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PartySize1
            // 
            this.PartySize1.BackColor = System.Drawing.Color.Transparent;
            this.PartySize1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.PartySize1.BorderThickness = 0;
            this.PartySize1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PartySize1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PartySize1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PartySize1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PartySize1.DisabledState.Parent = this.PartySize1;
            this.PartySize1.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.PartySize1.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.PartySize1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PartySize1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PartySize1.FocusedState.Parent = this.PartySize1;
            this.PartySize1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartySize1.ForeColor = System.Drawing.Color.White;
            this.PartySize1.Location = new System.Drawing.Point(291, 302);
            this.PartySize1.Name = "PartySize1";
            this.PartySize1.ShadowDecoration.BorderRadius = 3;
            this.PartySize1.ShadowDecoration.Depth = 10;
            this.PartySize1.ShadowDecoration.Enabled = true;
            this.PartySize1.ShadowDecoration.Parent = this.PartySize1;
            this.PartySize1.Size = new System.Drawing.Size(65, 36);
            this.PartySize1.TabIndex = 5;
            this.PartySize1.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PartySize1.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // PartySize2
            // 
            this.PartySize2.BackColor = System.Drawing.Color.Transparent;
            this.PartySize2.BorderThickness = 0;
            this.PartySize2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PartySize2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PartySize2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PartySize2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PartySize2.DisabledState.Parent = this.PartySize2;
            this.PartySize2.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.PartySize2.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.PartySize2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.PartySize2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PartySize2.FocusedState.Parent = this.PartySize2;
            this.PartySize2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartySize2.ForeColor = System.Drawing.Color.White;
            this.PartySize2.Location = new System.Drawing.Point(426, 302);
            this.PartySize2.Name = "PartySize2";
            this.PartySize2.ShadowDecoration.BorderRadius = 3;
            this.PartySize2.ShadowDecoration.Depth = 10;
            this.PartySize2.ShadowDecoration.Enabled = true;
            this.PartySize2.ShadowDecoration.Parent = this.PartySize2;
            this.PartySize2.Size = new System.Drawing.Size(65, 36);
            this.PartySize2.TabIndex = 5;
            this.PartySize2.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PartySize2.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // siticoneLabel8
            // 
            this.siticoneLabel8.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.siticoneLabel8.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel8.Location = new System.Drawing.Point(381, 308);
            this.siticoneLabel8.Name = "siticoneLabel8";
            this.siticoneLabel8.Size = new System.Drawing.Size(19, 23);
            this.siticoneLabel8.TabIndex = 3;
            this.siticoneLabel8.Text = "of";
            // 
            // siticoneLabel9
            // 
            this.siticoneLabel9.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel9.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.siticoneLabel9.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel9.Location = new System.Drawing.Point(353, 273);
            this.siticoneLabel9.Name = "siticoneLabel9";
            this.siticoneLabel9.Size = new System.Drawing.Size(77, 23);
            this.siticoneLabel9.TabIndex = 3;
            this.siticoneLabel9.Text = "Party Size";
            // 
            // ActivateButton
            // 
            this.ActivateButton.BorderRadius = 4;
            this.ActivateButton.CheckedState.Parent = this.ActivateButton;
            this.ActivateButton.CustomImages.Parent = this.ActivateButton;
            this.ActivateButton.Enabled = false;
            this.ActivateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ActivateButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateButton.ForeColor = System.Drawing.Color.White;
            this.ActivateButton.HoveredState.Parent = this.ActivateButton;
            this.ActivateButton.Location = new System.Drawing.Point(50, 324);
            this.ActivateButton.Name = "ActivateButton";
            this.ActivateButton.ShadowDecoration.Parent = this.ActivateButton;
            this.ActivateButton.Size = new System.Drawing.Size(180, 45);
            this.ActivateButton.TabIndex = 2;
            this.ActivateButton.Text = "Change Presence";
            this.ActivateButton.Click += new System.EventHandler(this.ActivateButton_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "DRPC";
            this.trayIcon.Visible = true;
            this.trayIcon.Click += new System.EventHandler(this.trayIcon_Click);
            // 
            // InjectButton
            // 
            this.InjectButton.BorderRadius = 4;
            this.InjectButton.CheckedState.Parent = this.InjectButton;
            this.InjectButton.CustomImages.Parent = this.InjectButton;
            this.InjectButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.InjectButton.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InjectButton.ForeColor = System.Drawing.Color.White;
            this.InjectButton.HoveredState.Parent = this.InjectButton;
            this.InjectButton.Location = new System.Drawing.Point(50, 273);
            this.InjectButton.Name = "InjectButton";
            this.InjectButton.ShadowDecoration.Parent = this.InjectButton;
            this.InjectButton.Size = new System.Drawing.Size(180, 45);
            this.InjectButton.TabIndex = 2;
            this.InjectButton.Text = "Initialize App ID";
            this.InjectButton.Click += new System.EventHandler(this.InjectButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(784, 388);
            this.Controls.Add(this.PartySize2);
            this.Controls.Add(this.PartySize1);
            this.Controls.Add(this.SImgTBox);
            this.Controls.Add(this.DetailsTBox);
            this.Controls.Add(this.LImgTextTBox);
            this.Controls.Add(this.StateTBox);
            this.Controls.Add(this.SImgTextTBox);
            this.Controls.Add(this.LImgTBox);
            this.Controls.Add(this.siticoneLabel6);
            this.Controls.Add(this.AppIdTBox);
            this.Controls.Add(this.siticoneLabel8);
            this.Controls.Add(this.siticoneLabel9);
            this.Controls.Add(this.siticoneLabel5);
            this.Controls.Add(this.siticoneLabel7);
            this.Controls.Add(this.siticoneLabel3);
            this.Controls.Add(this.siticoneLabel4);
            this.Controls.Add(this.siticoneLabel2);
            this.Controls.Add(this.siticoneLabel1);
            this.Controls.Add(this.InjectButton);
            this.Controls.Add(this.ActivateButton);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DRPC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartySize1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartySize2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePanel TopPanel;
        private Siticone.UI.WinForms.SiticoneImageButton MinimizeImageButton;
        private System.Windows.Forms.Label NameLabel;
        private Siticone.UI.WinForms.SiticoneImageButton CloseImageButton;
        private Siticone.UI.WinForms.SiticonePictureBox LogoPicture;
        private Siticone.UI.WinForms.SiticoneElipse ElipseForm;
        private Siticone.UI.WinForms.SiticoneTransparentDrag DragTopPanel;
        private Siticone.UI.WinForms.SiticoneTransparentDrag DragHaloxxLogo;
        private Siticone.UI.WinForms.SiticoneTransparentDrag DragNameLabel;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox AppIdTBox;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox DetailsTBox;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox StateTBox;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel3;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel2;
        private Siticone.UI.WinForms.SiticoneNumericUpDown PartySize2;
        private Siticone.UI.WinForms.SiticoneNumericUpDown PartySize1;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox SImgTBox;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox LImgTextTBox;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox SImgTextTBox;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox LImgTBox;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel6;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel8;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel9;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel5;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel7;
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel4;
        private Siticone.UI.WinForms.SiticoneButton ActivateButton;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private Siticone.UI.WinForms.SiticoneButton InjectButton;
    }
}

