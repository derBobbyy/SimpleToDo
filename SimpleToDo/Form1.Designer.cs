namespace SimpleToDo
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.tbxEingabe = new Bunifu.UI.WinForms.BunifuTextBox();
            this.addBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.deleteBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lstToDo = new System.Windows.Forms.ListBox();
            this.updateBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // tbxEingabe
            // 
            this.tbxEingabe.AcceptsReturn = false;
            this.tbxEingabe.AcceptsTab = false;
            this.tbxEingabe.AnimationSpeed = 200;
            this.tbxEingabe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbxEingabe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbxEingabe.BackColor = System.Drawing.Color.Transparent;
            this.tbxEingabe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbxEingabe.BackgroundImage")));
            this.tbxEingabe.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbxEingabe.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbxEingabe.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbxEingabe.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbxEingabe.BorderRadius = 1;
            this.tbxEingabe.BorderThickness = 1;
            this.tbxEingabe.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbxEingabe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxEingabe.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.tbxEingabe.DefaultText = "";
            this.tbxEingabe.FillColor = System.Drawing.Color.White;
            this.tbxEingabe.HideSelection = true;
            this.tbxEingabe.IconLeft = null;
            this.tbxEingabe.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxEingabe.IconPadding = 10;
            this.tbxEingabe.IconRight = null;
            this.tbxEingabe.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxEingabe.Lines = new string[0];
            this.tbxEingabe.Location = new System.Drawing.Point(32, 34);
            this.tbxEingabe.MaxLength = 32767;
            this.tbxEingabe.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbxEingabe.Modified = false;
            this.tbxEingabe.Multiline = false;
            this.tbxEingabe.Name = "tbxEingabe";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbxEingabe.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbxEingabe.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbxEingabe.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbxEingabe.OnIdleState = stateProperties4;
            this.tbxEingabe.Padding = new System.Windows.Forms.Padding(3);
            this.tbxEingabe.PasswordChar = '\0';
            this.tbxEingabe.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbxEingabe.PlaceholderText = "Enter text";
            this.tbxEingabe.ReadOnly = false;
            this.tbxEingabe.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbxEingabe.SelectedText = "";
            this.tbxEingabe.SelectionLength = 0;
            this.tbxEingabe.SelectionStart = 0;
            this.tbxEingabe.ShortcutsEnabled = true;
            this.tbxEingabe.Size = new System.Drawing.Size(260, 37);
            this.tbxEingabe.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbxEingabe.TabIndex = 0;
            this.tbxEingabe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbxEingabe.TextMarginBottom = 0;
            this.tbxEingabe.TextMarginLeft = 3;
            this.tbxEingabe.TextMarginTop = 0;
            this.tbxEingabe.TextPlaceholder = "Enter text";
            this.tbxEingabe.UseSystemPasswordChar = false;
            this.tbxEingabe.WordWrap = true;
            // 
            // addBtn
            // 
            this.addBtn.AllowAnimations = true;
            this.addBtn.AllowMouseEffects = true;
            this.addBtn.AllowToggling = false;
            this.addBtn.AnimationSpeed = 200;
            this.addBtn.AutoGenerateColors = false;
            this.addBtn.AutoRoundBorders = true;
            this.addBtn.AutoSizeLeftIcon = true;
            this.addBtn.AutoSizeRightIcon = true;
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.addBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBtn.BackgroundImage")));
            this.addBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addBtn.ButtonText = "Add";
            this.addBtn.ButtonTextMarginLeft = 0;
            this.addBtn.ColorContrastOnClick = 45;
            this.addBtn.ColorContrastOnHover = 45;
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.addBtn.CustomizableEdges = borderEdges1;
            this.addBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.addBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.addBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.addBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.addBtn.IconMarginLeft = 11;
            this.addBtn.IconPadding = 10;
            this.addBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.addBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.addBtn.IconSize = 25;
            this.addBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.addBtn.IdleBorderRadius = 33;
            this.addBtn.IdleBorderThickness = 1;
            this.addBtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.addBtn.IdleIconLeftImage = null;
            this.addBtn.IdleIconRightImage = null;
            this.addBtn.IndicateFocus = false;
            this.addBtn.Location = new System.Drawing.Point(191, 77);
            this.addBtn.Name = "addBtn";
            this.addBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.addBtn.OnDisabledState.BorderRadius = 1;
            this.addBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addBtn.OnDisabledState.BorderThickness = 1;
            this.addBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.addBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.addBtn.OnDisabledState.IconLeftImage = null;
            this.addBtn.OnDisabledState.IconRightImage = null;
            this.addBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.addBtn.onHoverState.BorderRadius = 1;
            this.addBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addBtn.onHoverState.BorderThickness = 1;
            this.addBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.addBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.addBtn.onHoverState.IconLeftImage = null;
            this.addBtn.onHoverState.IconRightImage = null;
            this.addBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.addBtn.OnIdleState.BorderRadius = 1;
            this.addBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addBtn.OnIdleState.BorderThickness = 1;
            this.addBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.addBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.addBtn.OnIdleState.IconLeftImage = null;
            this.addBtn.OnIdleState.IconRightImage = null;
            this.addBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.addBtn.OnPressedState.BorderRadius = 1;
            this.addBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.addBtn.OnPressedState.BorderThickness = 1;
            this.addBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.addBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.addBtn.OnPressedState.IconLeftImage = null;
            this.addBtn.OnPressedState.IconRightImage = null;
            this.addBtn.Size = new System.Drawing.Size(101, 35);
            this.addBtn.TabIndex = 1;
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.addBtn.TextMarginLeft = 0;
            this.addBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.addBtn.UseDefaultRadiusAndThickness = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.AllowAnimations = true;
            this.deleteBtn.AllowMouseEffects = true;
            this.deleteBtn.AllowToggling = false;
            this.deleteBtn.AnimationSpeed = 200;
            this.deleteBtn.AutoGenerateColors = false;
            this.deleteBtn.AutoRoundBorders = true;
            this.deleteBtn.AutoSizeLeftIcon = true;
            this.deleteBtn.AutoSizeRightIcon = true;
            this.deleteBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteBtn.BackgroundImage")));
            this.deleteBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteBtn.ButtonText = "Delete";
            this.deleteBtn.ButtonTextMarginLeft = 0;
            this.deleteBtn.ColorContrastOnClick = 45;
            this.deleteBtn.ColorContrastOnHover = 45;
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.deleteBtn.CustomizableEdges = borderEdges2;
            this.deleteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.deleteBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.deleteBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.deleteBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.deleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.deleteBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.deleteBtn.IconMarginLeft = 11;
            this.deleteBtn.IconPadding = 10;
            this.deleteBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.deleteBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.deleteBtn.IconSize = 25;
            this.deleteBtn.IdleBorderColor = System.Drawing.Color.Crimson;
            this.deleteBtn.IdleBorderRadius = 33;
            this.deleteBtn.IdleBorderThickness = 1;
            this.deleteBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBtn.IdleIconLeftImage = null;
            this.deleteBtn.IdleIconRightImage = null;
            this.deleteBtn.IndicateFocus = false;
            this.deleteBtn.Location = new System.Drawing.Point(32, 77);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.deleteBtn.OnDisabledState.BorderRadius = 1;
            this.deleteBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteBtn.OnDisabledState.BorderThickness = 1;
            this.deleteBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.deleteBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.deleteBtn.OnDisabledState.IconLeftImage = null;
            this.deleteBtn.OnDisabledState.IconRightImage = null;
            this.deleteBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.deleteBtn.onHoverState.BorderRadius = 1;
            this.deleteBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteBtn.onHoverState.BorderThickness = 1;
            this.deleteBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.deleteBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.onHoverState.IconLeftImage = null;
            this.deleteBtn.onHoverState.IconRightImage = null;
            this.deleteBtn.OnIdleState.BorderColor = System.Drawing.Color.Crimson;
            this.deleteBtn.OnIdleState.BorderRadius = 1;
            this.deleteBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteBtn.OnIdleState.BorderThickness = 1;
            this.deleteBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.OnIdleState.IconLeftImage = null;
            this.deleteBtn.OnIdleState.IconRightImage = null;
            this.deleteBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.deleteBtn.OnPressedState.BorderRadius = 1;
            this.deleteBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deleteBtn.OnPressedState.BorderThickness = 1;
            this.deleteBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.deleteBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.OnPressedState.IconLeftImage = null;
            this.deleteBtn.OnPressedState.IconRightImage = null;
            this.deleteBtn.Size = new System.Drawing.Size(101, 35);
            this.deleteBtn.TabIndex = 1;
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deleteBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteBtn.TextMarginLeft = 0;
            this.deleteBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.deleteBtn.UseDefaultRadiusAndThickness = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // lstToDo
            // 
            this.lstToDo.FormattingEnabled = true;
            this.lstToDo.Location = new System.Drawing.Point(32, 137);
            this.lstToDo.Name = "lstToDo";
            this.lstToDo.Size = new System.Drawing.Size(260, 264);
            this.lstToDo.TabIndex = 2;
            // 
            // updateBtn
            // 
            this.updateBtn.AllowAnimations = true;
            this.updateBtn.AllowMouseEffects = true;
            this.updateBtn.AllowToggling = false;
            this.updateBtn.AnimationSpeed = 200;
            this.updateBtn.AutoGenerateColors = false;
            this.updateBtn.AutoRoundBorders = true;
            this.updateBtn.AutoSizeLeftIcon = true;
            this.updateBtn.AutoSizeRightIcon = true;
            this.updateBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateBtn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.updateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateBtn.BackgroundImage")));
            this.updateBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updateBtn.ButtonText = "Update";
            this.updateBtn.ButtonTextMarginLeft = 0;
            this.updateBtn.ColorContrastOnClick = 45;
            this.updateBtn.ColorContrastOnHover = 45;
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.updateBtn.CustomizableEdges = borderEdges3;
            this.updateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.updateBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.updateBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.updateBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.updateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.updateBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.updateBtn.IconMarginLeft = 11;
            this.updateBtn.IconPadding = 10;
            this.updateBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updateBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.updateBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.updateBtn.IconSize = 25;
            this.updateBtn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.updateBtn.IdleBorderRadius = 33;
            this.updateBtn.IdleBorderThickness = 1;
            this.updateBtn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.updateBtn.IdleIconLeftImage = null;
            this.updateBtn.IdleIconRightImage = null;
            this.updateBtn.IndicateFocus = false;
            this.updateBtn.Location = new System.Drawing.Point(191, 409);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.updateBtn.OnDisabledState.BorderRadius = 1;
            this.updateBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updateBtn.OnDisabledState.BorderThickness = 1;
            this.updateBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.updateBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.updateBtn.OnDisabledState.IconLeftImage = null;
            this.updateBtn.OnDisabledState.IconRightImage = null;
            this.updateBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.updateBtn.onHoverState.BorderRadius = 1;
            this.updateBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updateBtn.onHoverState.BorderThickness = 1;
            this.updateBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.updateBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.updateBtn.onHoverState.IconLeftImage = null;
            this.updateBtn.onHoverState.IconRightImage = null;
            this.updateBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.updateBtn.OnIdleState.BorderRadius = 1;
            this.updateBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updateBtn.OnIdleState.BorderThickness = 1;
            this.updateBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.updateBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.updateBtn.OnIdleState.IconLeftImage = null;
            this.updateBtn.OnIdleState.IconRightImage = null;
            this.updateBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.updateBtn.OnPressedState.BorderRadius = 1;
            this.updateBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.updateBtn.OnPressedState.BorderThickness = 1;
            this.updateBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.updateBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.updateBtn.OnPressedState.IconLeftImage = null;
            this.updateBtn.OnPressedState.IconRightImage = null;
            this.updateBtn.Size = new System.Drawing.Size(101, 35);
            this.updateBtn.TabIndex = 1;
            this.updateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.updateBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.updateBtn.TextMarginLeft = 0;
            this.updateBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.updateBtn.UseDefaultRadiusAndThickness = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 456);
            this.Controls.Add(this.lstToDo);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.tbxEingabe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(342, 495);
            this.MinimumSize = new System.Drawing.Size(342, 495);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox tbxEingabe;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton addBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton deleteBtn;
        private System.Windows.Forms.ListBox lstToDo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton updateBtn;
    }
}

