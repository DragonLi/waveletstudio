﻿namespace WaveletStudio.MainApplication.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.qRibbonCaption2 = new Qios.DevSuite.Components.Ribbon.QRibbonCaption();
            this.qRibbonApplicationButton1 = new Qios.DevSuite.Components.Ribbon.QRibbonApplicationButton();
            this.qRibbonItem1 = new Qios.DevSuite.Components.Ribbon.QRibbonItem();
            this.qCompositeButton2 = new Qios.DevSuite.Components.QCompositeButton();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.OriginalSignalGraph = new ZedGraph.ZedGraphControl();
            this.CreatedSignalGraph = new ZedGraph.ZedGraphControl();
            this.ShowOriginalSignalCheckBox = new System.Windows.Forms.CheckBox();
            this.ShowCreatedSignal = new System.Windows.Forms.CheckBox();
            this.qCompositeGroup16 = new Qios.DevSuite.Components.QCompositeGroup();
            this.Ribbon = new Qios.DevSuite.Components.Ribbon.QRibbon();
            this.SignalRibbonPage = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
            this.SignalTemplatePanel = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.SignalTemplatesComposite = new Qios.DevSuite.Components.QCompositeGroup();
            this.OperationsRibbonPage = new Qios.DevSuite.Components.Ribbon.QRibbonPage();
            this.OperationsFunctionsPanel = new Qios.DevSuite.Components.Ribbon.QRibbonPanel();
            this.OperationsFunctionsComposite = new Qios.DevSuite.Components.QCompositeGroup();
            this.StepsComposite = new Qios.DevSuite.Components.QCompositeControl();
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ribbon)).BeginInit();
            this.Ribbon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignalRibbonPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsRibbonPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsComposite)).BeginInit();
            this.SuspendLayout();
            // 
            // qRibbonCaption2
            // 
            this.qRibbonCaption2.ApplicationButton = this.qRibbonApplicationButton1;
            this.qRibbonCaption2.Configuration.ApplicationButtonAreaConfiguration.Margin = new Qios.DevSuite.Components.QMargin(0, 4, 0, -8);
            this.qRibbonCaption2.Configuration.IconConfiguration.Visible = Qios.DevSuite.Components.QTristateBool.False;
            this.qRibbonCaption2.Location = new System.Drawing.Point(0, 0);
            this.qRibbonCaption2.Name = "qRibbonCaption2";
            this.qRibbonCaption2.Size = new System.Drawing.Size(1094, 28);
            this.qRibbonCaption2.TabIndex = 49;
            this.qRibbonCaption2.Text = "Wavelet Studio";
            // 
            // qRibbonApplicationButton1
            // 
            this.qRibbonApplicationButton1.ForegroundImage = global::WaveletStudio.MainApplication.Properties.Resources.sine;
            // 
            // qRibbonItem1
            // 
            this.qRibbonItem1.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.qRibbonItem1.Configuration.IconConfiguration.IconSize = new System.Drawing.Size(32, 32);
            this.qRibbonItem1.HotkeyText = "F";
            this.qRibbonItem1.Icon = ((System.Drawing.Icon)(resources.GetObject("qRibbonItem1.Icon")));
            this.qRibbonItem1.Title = "Find";
            // 
            // qCompositeButton2
            // 
            this.qCompositeButton2.Icon = ((System.Drawing.Icon)(resources.GetObject("qCompositeButton2.Icon")));
            this.qCompositeButton2.Title = "qCompositeButton1";
            // 
            // SplitContainer
            // 
            this.SplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer.Location = new System.Drawing.Point(2, 172);
            this.SplitContainer.Name = "SplitContainer";
            this.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.Controls.Add(this.OriginalSignalGraph);
            this.SplitContainer.Panel1MinSize = 50;
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.Controls.Add(this.CreatedSignalGraph);
            this.SplitContainer.Panel2MinSize = 50;
            this.SplitContainer.Size = new System.Drawing.Size(860, 585);
            this.SplitContainer.SplitterDistance = 300;
            this.SplitContainer.TabIndex = 46;
            // 
            // OriginalSignalGraph
            // 
            this.OriginalSignalGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OriginalSignalGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalSignalGraph.Location = new System.Drawing.Point(0, 0);
            this.OriginalSignalGraph.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OriginalSignalGraph.Name = "OriginalSignalGraph";
            this.OriginalSignalGraph.ScrollGrace = 0D;
            this.OriginalSignalGraph.ScrollMaxX = 0D;
            this.OriginalSignalGraph.ScrollMaxY = 0D;
            this.OriginalSignalGraph.ScrollMaxY2 = 0D;
            this.OriginalSignalGraph.ScrollMinX = 0D;
            this.OriginalSignalGraph.ScrollMinY = 0D;
            this.OriginalSignalGraph.ScrollMinY2 = 0D;
            this.OriginalSignalGraph.Size = new System.Drawing.Size(860, 300);
            this.OriginalSignalGraph.TabIndex = 47;
            // 
            // CreatedSignalGraph
            // 
            this.CreatedSignalGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreatedSignalGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedSignalGraph.Location = new System.Drawing.Point(0, 0);
            this.CreatedSignalGraph.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreatedSignalGraph.Name = "CreatedSignalGraph";
            this.CreatedSignalGraph.ScrollGrace = 0D;
            this.CreatedSignalGraph.ScrollMaxX = 0D;
            this.CreatedSignalGraph.ScrollMaxY = 0D;
            this.CreatedSignalGraph.ScrollMaxY2 = 0D;
            this.CreatedSignalGraph.ScrollMinX = 0D;
            this.CreatedSignalGraph.ScrollMinY = 0D;
            this.CreatedSignalGraph.ScrollMinY2 = 0D;
            this.CreatedSignalGraph.Size = new System.Drawing.Size(860, 281);
            this.CreatedSignalGraph.TabIndex = 48;
            // 
            // ShowOriginalSignalCheckBox
            // 
            this.ShowOriginalSignalCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowOriginalSignalCheckBox.AutoSize = true;
            this.ShowOriginalSignalCheckBox.Checked = true;
            this.ShowOriginalSignalCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowOriginalSignalCheckBox.Location = new System.Drawing.Point(2, 768);
            this.ShowOriginalSignalCheckBox.Name = "ShowOriginalSignalCheckBox";
            this.ShowOriginalSignalCheckBox.Size = new System.Drawing.Size(123, 17);
            this.ShowOriginalSignalCheckBox.TabIndex = 47;
            this.ShowOriginalSignalCheckBox.Text = "Show Original Signal";
            this.ShowOriginalSignalCheckBox.UseVisualStyleBackColor = true;
            this.ShowOriginalSignalCheckBox.CheckedChanged += new System.EventHandler(this.ShowSignalCheckBoxCheckedChanged);
            // 
            // ShowCreatedSignal
            // 
            this.ShowCreatedSignal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowCreatedSignal.AutoSize = true;
            this.ShowCreatedSignal.Checked = true;
            this.ShowCreatedSignal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowCreatedSignal.Location = new System.Drawing.Point(131, 768);
            this.ShowCreatedSignal.Name = "ShowCreatedSignal";
            this.ShowCreatedSignal.Size = new System.Drawing.Size(119, 17);
            this.ShowCreatedSignal.TabIndex = 48;
            this.ShowCreatedSignal.Text = "ShowCreatedSignal";
            this.ShowCreatedSignal.UseVisualStyleBackColor = true;
            this.ShowCreatedSignal.CheckedChanged += new System.EventHandler(this.ShowSignalCheckBoxCheckedChanged);
            // 
            // qCompositeGroup16
            // 
            this.qCompositeGroup16.ColorScheme.ButtonHotBackground1.SetColor("Default", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.ButtonHotBackground1.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.ButtonHotBackground1.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.ButtonHotBackground1.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.ButtonHotBackground1.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.ButtonHotBackground2.SetColor("Default", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.ButtonHotBackground2.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.ButtonHotBackground2.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.ButtonHotBackground2.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.ButtonHotBackground2.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeButtonBackground1.SetColor("Default", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeButtonBackground1.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeButtonBackground1.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeButtonBackground1.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeButtonBackground1.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeButtonBackground2.SetColor("Default", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeButtonBackground2.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeButtonBackground2.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeButtonBackground2.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeButtonBackground2.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeGroupBackground1.SetColor("Default", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeGroupBackground1.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeGroupBackground1.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeGroupBackground1.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeGroupBackground1.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeGroupBackground2.SetColor("Default", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeGroupBackground2.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeGroupBackground2.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeGroupBackground2.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeGroupBackground2.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemBackground1.SetColor("Default", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemBackground1.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemBackground1.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemBackground1.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemBackground1.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemBackground2.SetColor("Default", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemExpandedBackground1.SetColor("Default", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemExpandedBackground1.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemExpandedBackground1.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemExpandedBackground1.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemExpandedBackground1.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemExpandedBackground2.SetColor("Default", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemExpandedBackground2.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemExpandedBackground2.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemExpandedBackground2.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemExpandedBackground2.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemHotBackground1.SetColor("Default", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemHotBackground1.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemHotBackground1.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemHotBackground1.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemHotBackground1.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemHotBackground2.SetColor("Default", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemPressedBackground1.SetColor("Default", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemPressedBackground1.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemPressedBackground1.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemPressedBackground1.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemPressedBackground1.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemPressedBackground2.SetColor("Default", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemPressedBackground2.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemPressedBackground2.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemPressedBackground2.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.CompositeItemPressedBackground2.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.qCompositeGroup16.ColorScheme.Scope = Qios.DevSuite.Components.QColorSchemeScope.All;
            this.qCompositeGroup16.Configuration.Appearance.BackgroundStyle = Qios.DevSuite.Components.QColorStyle.Solid;
            this.qCompositeGroup16.Configuration.Appearance.BorderWidth = 0;
            this.qCompositeGroup16.Configuration.Padding = new Qios.DevSuite.Components.QPadding(0, 0, 0, 0);
            this.qCompositeGroup16.Configuration.StretchHorizontal = true;
            this.qCompositeGroup16.Configuration.StretchVertical = true;
            // 
            // Ribbon
            // 
            this.Ribbon.ActiveTabPage = this.SignalRibbonPage;
            this.Ribbon.Controls.Add(this.SignalRibbonPage);
            this.Ribbon.Controls.Add(this.OperationsRibbonPage);
            this.Ribbon.Cursor = System.Windows.Forms.Cursors.Default;
            this.Ribbon.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ribbon.Form = this;
            this.Ribbon.Location = new System.Drawing.Point(0, 28);
            this.Ribbon.Name = "Ribbon";
            this.Ribbon.PersistGuid = new System.Guid("f549a281-ecb8-4c57-ab72-08ae6e49b352");
            this.Ribbon.Size = new System.Drawing.Size(1094, 138);
            this.Ribbon.TabIndex = 50;
            this.Ribbon.TabStripConfiguration.ButtonAreaMargin = new Qios.DevSuite.Components.QMargin(35, 5, 0, 0);
            this.Ribbon.Text = "Sinal";
            // 
            // SignalRibbonPage
            // 
            this.SignalRibbonPage.ButtonOrder = 0;
            this.SignalRibbonPage.HotkeyText = "QR";
            this.SignalRibbonPage.Items.Add(this.SignalTemplatePanel);
            this.SignalRibbonPage.Location = new System.Drawing.Point(2, 28);
            this.SignalRibbonPage.Name = "SignalRibbonPage";
            this.SignalRibbonPage.PersistGuid = new System.Guid("ea85f321-5f5d-4be5-b84e-e09b73b23a86");
            this.SignalRibbonPage.Size = new System.Drawing.Size(1088, 106);
            this.SignalRibbonPage.Text = "Signal";
            // 
            // SignalTemplatePanel
            // 
            this.SignalTemplatePanel.Items.Add(this.SignalTemplatesComposite);
            this.SignalTemplatePanel.Title = "Signal Templates";
            // 
            // SignalTemplatesComposite
            // 
            this.SignalTemplatesComposite.ColorScheme.ButtonPressedBackground1.SetColor("Default", System.Drawing.Color.Empty, false);
            this.SignalTemplatesComposite.ColorScheme.ButtonPressedBackground1.SetColor("LunaBlue", System.Drawing.Color.Empty, false);
            this.SignalTemplatesComposite.ColorScheme.ButtonPressedBackground1.SetColor("LunaOlive", System.Drawing.Color.Empty, false);
            this.SignalTemplatesComposite.ColorScheme.ButtonPressedBackground1.SetColor("LunaSilver", System.Drawing.Color.Empty, false);
            this.SignalTemplatesComposite.ColorScheme.ButtonPressedBackground1.SetColor("VistaBlack", System.Drawing.Color.Empty, false);
            this.SignalTemplatesComposite.ColorScheme.ButtonPressedBackground2.SetColor("Default", System.Drawing.Color.Empty, false);
            this.SignalTemplatesComposite.ColorScheme.ButtonPressedBackground2.SetColor("LunaBlue", System.Drawing.Color.Empty, false);
            this.SignalTemplatesComposite.ColorScheme.ButtonPressedBackground2.SetColor("LunaOlive", System.Drawing.Color.Empty, false);
            this.SignalTemplatesComposite.ColorScheme.ButtonPressedBackground2.SetColor("LunaSilver", System.Drawing.Color.Empty, false);
            this.SignalTemplatesComposite.ColorScheme.ButtonPressedBackground2.SetColor("VistaBlack", System.Drawing.Color.Empty, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemBackground1.SetColor("Default", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemBackground1.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemBackground1.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemBackground1.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemBackground1.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemBackground2.SetColor("Default", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemBackground2.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemBackground2.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemBackground2.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemBackground2.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemHotBackground1.SetColor("Default", System.Drawing.Color.Transparent, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemHotBackground1.SetColor("LunaBlue", System.Drawing.Color.Transparent, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemHotBackground1.SetColor("LunaOlive", System.Drawing.Color.Transparent, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemHotBackground1.SetColor("LunaSilver", System.Drawing.Color.Transparent, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemHotBackground1.SetColor("VistaBlack", System.Drawing.Color.Transparent, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemHotBackground2.SetColor("Default", System.Drawing.Color.Transparent, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemHotBackground2.SetColor("LunaBlue", System.Drawing.Color.Transparent, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemHotBackground2.SetColor("LunaOlive", System.Drawing.Color.Transparent, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemHotBackground2.SetColor("LunaSilver", System.Drawing.Color.Transparent, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemHotBackground2.SetColor("VistaBlack", System.Drawing.Color.Transparent, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemHotBorder.SetColor("Default", System.Drawing.Color.Transparent, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemHotBorder.SetColor("LunaBlue", System.Drawing.Color.Transparent, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemHotBorder.SetColor("LunaOlive", System.Drawing.Color.Transparent, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemHotBorder.SetColor("LunaSilver", System.Drawing.Color.Transparent, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemHotBorder.SetColor("VistaBlack", System.Drawing.Color.Transparent, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemPressedBackground1.SetColor("Default", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemPressedBackground1.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemPressedBackground1.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemPressedBackground1.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemPressedBackground1.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemPressedBackground2.SetColor("Default", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemPressedBackground2.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemPressedBackground2.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemPressedBackground2.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.CompositeItemPressedBackground2.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.SignalTemplatesComposite.ColorScheme.Scope = Qios.DevSuite.Components.QColorSchemeScope.All;
            this.SignalTemplatesComposite.Configuration.ShrinkHorizontal = true;
            this.SignalTemplatesComposite.Configuration.ShrinkVertical = true;
            this.SignalTemplatesComposite.Configuration.StretchHorizontal = true;
            this.SignalTemplatesComposite.Configuration.StretchVertical = true;
            // 
            // OperationsRibbonPage
            // 
            this.OperationsRibbonPage.ButtonOrder = 1;
            this.OperationsRibbonPage.Items.Add(this.OperationsFunctionsPanel);
            this.OperationsRibbonPage.Location = new System.Drawing.Point(2, 28);
            this.OperationsRibbonPage.Name = "OperationsRibbonPage";
            this.OperationsRibbonPage.PersistGuid = new System.Guid("e11d0cdc-ac5f-4668-9777-2c1ea1c812c5");
            this.OperationsRibbonPage.Size = new System.Drawing.Size(1088, 106);
            this.OperationsRibbonPage.Text = "Operations";
            // 
            // OperationsFunctionsPanel
            // 
            this.OperationsFunctionsPanel.Items.Add(this.OperationsFunctionsComposite);
            this.OperationsFunctionsPanel.Title = "Functions";
            // 
            // OperationsFunctionsComposite
            // 
            this.OperationsFunctionsComposite.ColorScheme.ButtonPressedBackground1.SetColor("Default", System.Drawing.Color.Empty, false);
            this.OperationsFunctionsComposite.ColorScheme.ButtonPressedBackground1.SetColor("LunaBlue", System.Drawing.Color.Empty, false);
            this.OperationsFunctionsComposite.ColorScheme.ButtonPressedBackground1.SetColor("LunaOlive", System.Drawing.Color.Empty, false);
            this.OperationsFunctionsComposite.ColorScheme.ButtonPressedBackground1.SetColor("LunaSilver", System.Drawing.Color.Empty, false);
            this.OperationsFunctionsComposite.ColorScheme.ButtonPressedBackground1.SetColor("VistaBlack", System.Drawing.Color.Empty, false);
            this.OperationsFunctionsComposite.ColorScheme.ButtonPressedBackground2.SetColor("Default", System.Drawing.Color.Empty, false);
            this.OperationsFunctionsComposite.ColorScheme.ButtonPressedBackground2.SetColor("LunaBlue", System.Drawing.Color.Empty, false);
            this.OperationsFunctionsComposite.ColorScheme.ButtonPressedBackground2.SetColor("LunaOlive", System.Drawing.Color.Empty, false);
            this.OperationsFunctionsComposite.ColorScheme.ButtonPressedBackground2.SetColor("LunaSilver", System.Drawing.Color.Empty, false);
            this.OperationsFunctionsComposite.ColorScheme.ButtonPressedBackground2.SetColor("VistaBlack", System.Drawing.Color.Empty, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemBackground1.SetColor("Default", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemBackground1.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemBackground1.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemBackground1.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemBackground1.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemBackground2.SetColor("Default", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemBackground2.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemBackground2.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemBackground2.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemBackground2.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemHotBackground1.SetColor("Default", System.Drawing.Color.Transparent, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemHotBackground1.SetColor("LunaBlue", System.Drawing.Color.Transparent, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemHotBackground1.SetColor("LunaOlive", System.Drawing.Color.Transparent, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemHotBackground1.SetColor("LunaSilver", System.Drawing.Color.Transparent, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemHotBackground1.SetColor("VistaBlack", System.Drawing.Color.Transparent, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemHotBackground2.SetColor("Default", System.Drawing.Color.Transparent, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemHotBackground2.SetColor("LunaBlue", System.Drawing.Color.Transparent, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemHotBackground2.SetColor("LunaOlive", System.Drawing.Color.Transparent, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemHotBackground2.SetColor("LunaSilver", System.Drawing.Color.Transparent, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemHotBackground2.SetColor("VistaBlack", System.Drawing.Color.Transparent, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemHotBorder.SetColor("Default", System.Drawing.Color.Transparent, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemHotBorder.SetColor("LunaBlue", System.Drawing.Color.Transparent, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemHotBorder.SetColor("LunaOlive", System.Drawing.Color.Transparent, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemHotBorder.SetColor("LunaSilver", System.Drawing.Color.Transparent, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemHotBorder.SetColor("VistaBlack", System.Drawing.Color.Transparent, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemPressedBackground1.SetColor("Default", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemPressedBackground1.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemPressedBackground1.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemPressedBackground1.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemPressedBackground1.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemPressedBackground2.SetColor("Default", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemPressedBackground2.SetColor("LunaBlue", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemPressedBackground2.SetColor("LunaOlive", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemPressedBackground2.SetColor("LunaSilver", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.CompositeItemPressedBackground2.SetColor("VistaBlack", System.Drawing.Color.White, false);
            this.OperationsFunctionsComposite.ColorScheme.Scope = Qios.DevSuite.Components.QColorSchemeScope.All;
            this.OperationsFunctionsComposite.Configuration.ShrinkHorizontal = true;
            this.OperationsFunctionsComposite.Configuration.ShrinkVertical = true;
            this.OperationsFunctionsComposite.Configuration.StretchHorizontal = true;
            this.OperationsFunctionsComposite.Configuration.StretchVertical = true;
            // 
            // StepsComposite
            // 
            this.StepsComposite.ColorScheme.CompositeBackground1.SetColor("Default", System.Drawing.Color.Empty, false);
            this.StepsComposite.ColorScheme.CompositeBackground1.SetColor("LunaBlue", System.Drawing.Color.Empty, false);
            this.StepsComposite.ColorScheme.CompositeBackground1.SetColor("LunaOlive", System.Drawing.Color.Empty, false);
            this.StepsComposite.ColorScheme.CompositeBackground1.SetColor("LunaSilver", System.Drawing.Color.Empty, false);
            this.StepsComposite.ColorScheme.CompositeBackground1.SetColor("VistaBlack", System.Drawing.Color.Empty, false);
            this.StepsComposite.ColorScheme.CompositeBackground2.SetColor("Default", System.Drawing.Color.Empty, false);
            this.StepsComposite.Configuration.Direction = Qios.DevSuite.Components.QPartDirection.Vertical;
            this.StepsComposite.Configuration.ScrollConfiguration.ScrollVertical = Qios.DevSuite.Components.QCompositeScrollVisibility.Automatic;
            this.StepsComposite.Dock = System.Windows.Forms.DockStyle.Right;
            this.StepsComposite.Location = new System.Drawing.Point(868, 166);
            this.StepsComposite.Name = "StepsComposite";
            this.StepsComposite.Size = new System.Drawing.Size(226, 628);
            this.StepsComposite.TabIndex = 51;
            this.StepsComposite.Text = "qCompositeControl1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 794);
            this.Controls.Add(this.StepsComposite);
            this.Controls.Add(this.Ribbon);
            this.Controls.Add(this.qRibbonCaption2);
            this.Controls.Add(this.ShowCreatedSignal);
            this.Controls.Add(this.ShowOriginalSignalCheckBox);
            this.Controls.Add(this.SplitContainer);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wavelet Studio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.qRibbonCaption2)).EndInit();
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ribbon)).EndInit();
            this.Ribbon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SignalRibbonPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsRibbonPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsComposite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Qios.DevSuite.Components.Ribbon.QRibbonItem qRibbonItem1;
        private Qios.DevSuite.Components.QCompositeButton qCompositeButton2;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.CheckBox ShowOriginalSignalCheckBox;
        private System.Windows.Forms.CheckBox ShowCreatedSignal;
        private ZedGraph.ZedGraphControl OriginalSignalGraph;
        private ZedGraph.ZedGraphControl CreatedSignalGraph;
        private Qios.DevSuite.Components.QCompositeGroup qCompositeGroup16;
        private Qios.DevSuite.Components.Ribbon.QRibbonCaption qRibbonCaption2;
        private Qios.DevSuite.Components.Ribbon.QRibbonApplicationButton qRibbonApplicationButton1;
        private Qios.DevSuite.Components.Ribbon.QRibbon Ribbon;
        private Qios.DevSuite.Components.Ribbon.QRibbonPage SignalRibbonPage;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel SignalTemplatePanel;
        private Qios.DevSuite.Components.QCompositeGroup SignalTemplatesComposite;
        private Qios.DevSuite.Components.QCompositeControl StepsComposite;
        private Qios.DevSuite.Components.Ribbon.QRibbonPage OperationsRibbonPage;
        private Qios.DevSuite.Components.Ribbon.QRibbonPanel OperationsFunctionsPanel;
        private Qios.DevSuite.Components.QCompositeGroup OperationsFunctionsComposite;        

    }
}