namespace WindowsFormsApp1
{
    partial class PaskoinatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaskoinatorForm));
            this.AddFileButton = new System.Windows.Forms.Button();
            this.CreateStripButton = new System.Windows.Forms.Button();
            this.RadioWidthMin = new System.Windows.Forms.RadioButton();
            this.RadioWidthAvg = new System.Windows.Forms.RadioButton();
            this.RadioWidthMax = new System.Windows.Forms.RadioButton();
            this.RadioWidthUser = new System.Windows.Forms.RadioButton();
            this.WidthSetup = new System.Windows.Forms.GroupBox();
            this.WidthInput = new System.Windows.Forms.NumericUpDown();
            this.SpacingSetup = new System.Windows.Forms.GroupBox();
            this.SpacingColorButton = new System.Windows.Forms.Button();
            this.SpacingColorShower = new System.Windows.Forms.PictureBox();
            this.SpacingHandInput = new System.Windows.Forms.NumericUpDown();
            this.SpacingPercentInput = new System.Windows.Forms.NumericUpDown();
            this.RadioSpacingUser = new System.Windows.Forms.RadioButton();
            this.RadioSpacingPercent = new System.Windows.Forms.RadioButton();
            this.RadioSpacingNone = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.stripOverview = new System.Windows.Forms.Panel();
            this.GenerateOverview = new System.Windows.Forms.Button();
            this.ClearTheListButton = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.CreditsButton = new System.Windows.Forms.Button();
            this.TextHeight = new System.Windows.Forms.RichTextBox();
            this.TextWidth = new System.Windows.Forms.RichTextBox();
            this.stripProgressBar = new System.Windows.Forms.ProgressBar();
            this.WidthSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthInput)).BeginInit();
            this.SpacingSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpacingColorShower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpacingHandInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpacingPercentInput)).BeginInit();
            this.SuspendLayout();
            // 
            // AddFileButton
            // 
            this.AddFileButton.Location = new System.Drawing.Point(12, 12);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(179, 43);
            this.AddFileButton.TabIndex = 0;
            this.AddFileButton.Text = "Dodaj pliki";
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.AddFileButton_Click);
            // 
            // CreateStripButton
            // 
            this.CreateStripButton.AllowDrop = true;
            this.CreateStripButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CreateStripButton.Enabled = false;
            this.CreateStripButton.Location = new System.Drawing.Point(12, 408);
            this.CreateStripButton.Name = "CreateStripButton";
            this.CreateStripButton.Size = new System.Drawing.Size(179, 30);
            this.CreateStripButton.TabIndex = 1;
            this.CreateStripButton.Text = "Zrób mi pasek";
            this.CreateStripButton.UseVisualStyleBackColor = true;
            this.CreateStripButton.Click += new System.EventHandler(this.CreateStripButton_Click);
            // 
            // RadioWidthMin
            // 
            this.RadioWidthMin.AutoSize = true;
            this.RadioWidthMin.Location = new System.Drawing.Point(6, 65);
            this.RadioWidthMin.Name = "RadioWidthMin";
            this.RadioWidthMin.Size = new System.Drawing.Size(144, 17);
            this.RadioWidthMin.TabIndex = 2;
            this.RadioWidthMin.Text = "Szerokość najmniejszego";
            this.RadioWidthMin.UseVisualStyleBackColor = true;
            this.RadioWidthMin.CheckedChanged += new System.EventHandler(this.RadioWidthMin_CheckedChanged);
            // 
            // RadioWidthAvg
            // 
            this.RadioWidthAvg.AutoSize = true;
            this.RadioWidthAvg.Location = new System.Drawing.Point(6, 42);
            this.RadioWidthAvg.Name = "RadioWidthAvg";
            this.RadioWidthAvg.Size = new System.Drawing.Size(112, 17);
            this.RadioWidthAvg.TabIndex = 3;
            this.RadioWidthAvg.Text = "Średnia szerokość";
            this.RadioWidthAvg.UseVisualStyleBackColor = true;
            this.RadioWidthAvg.CheckedChanged += new System.EventHandler(this.RadioWidthAvg_CheckedChanged);
            // 
            // RadioWidthMax
            // 
            this.RadioWidthMax.AutoSize = true;
            this.RadioWidthMax.Checked = true;
            this.RadioWidthMax.Location = new System.Drawing.Point(6, 19);
            this.RadioWidthMax.Name = "RadioWidthMax";
            this.RadioWidthMax.Size = new System.Drawing.Size(142, 17);
            this.RadioWidthMax.TabIndex = 4;
            this.RadioWidthMax.TabStop = true;
            this.RadioWidthMax.Text = "Szerokość największego";
            this.RadioWidthMax.UseVisualStyleBackColor = true;
            this.RadioWidthMax.CheckedChanged += new System.EventHandler(this.RadioWidthMax_CheckedChanged);
            // 
            // RadioWidthUser
            // 
            this.RadioWidthUser.AutoSize = true;
            this.RadioWidthUser.Location = new System.Drawing.Point(6, 88);
            this.RadioWidthUser.Name = "RadioWidthUser";
            this.RadioWidthUser.Size = new System.Drawing.Size(62, 17);
            this.RadioWidthUser.TabIndex = 5;
            this.RadioWidthUser.Text = "Ręczna";
            this.RadioWidthUser.UseVisualStyleBackColor = true;
            this.RadioWidthUser.CheckedChanged += new System.EventHandler(this.RadioWidthUser_CheckedChanged);
            // 
            // WidthSetup
            // 
            this.WidthSetup.Controls.Add(this.WidthInput);
            this.WidthSetup.Controls.Add(this.RadioWidthMin);
            this.WidthSetup.Controls.Add(this.RadioWidthUser);
            this.WidthSetup.Controls.Add(this.RadioWidthAvg);
            this.WidthSetup.Controls.Add(this.RadioWidthMax);
            this.WidthSetup.Enabled = false;
            this.WidthSetup.Location = new System.Drawing.Point(12, 110);
            this.WidthSetup.Name = "WidthSetup";
            this.WidthSetup.Size = new System.Drawing.Size(179, 118);
            this.WidthSetup.TabIndex = 6;
            this.WidthSetup.TabStop = false;
            this.WidthSetup.Text = "Szerokość paska";
            // 
            // WidthInput
            // 
            this.WidthInput.Enabled = false;
            this.WidthInput.Location = new System.Drawing.Point(74, 89);
            this.WidthInput.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.WidthInput.Minimum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(99, 20);
            this.WidthInput.TabIndex = 6;
            this.WidthInput.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // SpacingSetup
            // 
            this.SpacingSetup.Controls.Add(this.SpacingColorButton);
            this.SpacingSetup.Controls.Add(this.SpacingColorShower);
            this.SpacingSetup.Controls.Add(this.SpacingHandInput);
            this.SpacingSetup.Controls.Add(this.SpacingPercentInput);
            this.SpacingSetup.Controls.Add(this.RadioSpacingUser);
            this.SpacingSetup.Controls.Add(this.RadioSpacingPercent);
            this.SpacingSetup.Controls.Add(this.RadioSpacingNone);
            this.SpacingSetup.Enabled = false;
            this.SpacingSetup.Location = new System.Drawing.Point(12, 234);
            this.SpacingSetup.Name = "SpacingSetup";
            this.SpacingSetup.Size = new System.Drawing.Size(179, 132);
            this.SpacingSetup.TabIndex = 7;
            this.SpacingSetup.TabStop = false;
            this.SpacingSetup.Text = "Szerokość przerwy pomiędzy obrazkami";
            // 
            // SpacingColorButton
            // 
            this.SpacingColorButton.Location = new System.Drawing.Point(6, 99);
            this.SpacingColorButton.Name = "SpacingColorButton";
            this.SpacingColorButton.Size = new System.Drawing.Size(78, 23);
            this.SpacingColorButton.TabIndex = 8;
            this.SpacingColorButton.Text = "Ustaw kolor";
            this.SpacingColorButton.UseVisualStyleBackColor = true;
            this.SpacingColorButton.Click += new System.EventHandler(this.SpacingColorButton_Click);
            // 
            // SpacingColorShower
            // 
            this.SpacingColorShower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SpacingColorShower.Location = new System.Drawing.Point(90, 99);
            this.SpacingColorShower.Name = "SpacingColorShower";
            this.SpacingColorShower.Size = new System.Drawing.Size(83, 23);
            this.SpacingColorShower.TabIndex = 8;
            this.SpacingColorShower.TabStop = false;
            // 
            // SpacingHandInput
            // 
            this.SpacingHandInput.Enabled = false;
            this.SpacingHandInput.Location = new System.Drawing.Point(74, 73);
            this.SpacingHandInput.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.SpacingHandInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SpacingHandInput.Name = "SpacingHandInput";
            this.SpacingHandInput.Size = new System.Drawing.Size(99, 20);
            this.SpacingHandInput.TabIndex = 8;
            this.SpacingHandInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SpacingPercentInput
            // 
            this.SpacingPercentInput.Enabled = false;
            this.SpacingPercentInput.Location = new System.Drawing.Point(127, 50);
            this.SpacingPercentInput.Name = "SpacingPercentInput";
            this.SpacingPercentInput.Size = new System.Drawing.Size(46, 20);
            this.SpacingPercentInput.TabIndex = 7;
            this.SpacingPercentInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // RadioSpacingUser
            // 
            this.RadioSpacingUser.AutoSize = true;
            this.RadioSpacingUser.Location = new System.Drawing.Point(6, 76);
            this.RadioSpacingUser.Name = "RadioSpacingUser";
            this.RadioSpacingUser.Size = new System.Drawing.Size(62, 17);
            this.RadioSpacingUser.TabIndex = 5;
            this.RadioSpacingUser.Text = "Ręczna";
            this.RadioSpacingUser.UseVisualStyleBackColor = true;
            this.RadioSpacingUser.CheckedChanged += new System.EventHandler(this.RadioSpacingUser_CheckedChanged);
            // 
            // RadioSpacingPercent
            // 
            this.RadioSpacingPercent.AutoSize = true;
            this.RadioSpacingPercent.Location = new System.Drawing.Point(6, 53);
            this.RadioSpacingPercent.Name = "RadioSpacingPercent";
            this.RadioSpacingPercent.Size = new System.Drawing.Size(115, 17);
            this.RadioSpacingPercent.TabIndex = 3;
            this.RadioSpacingPercent.Text = "Procent szerokości";
            this.RadioSpacingPercent.UseVisualStyleBackColor = true;
            this.RadioSpacingPercent.CheckedChanged += new System.EventHandler(this.RadioSpacingPercent_CheckedChanged);
            // 
            // RadioSpacingNone
            // 
            this.RadioSpacingNone.AutoSize = true;
            this.RadioSpacingNone.Checked = true;
            this.RadioSpacingNone.Location = new System.Drawing.Point(6, 30);
            this.RadioSpacingNone.Name = "RadioSpacingNone";
            this.RadioSpacingNone.Size = new System.Drawing.Size(47, 17);
            this.RadioSpacingNone.TabIndex = 4;
            this.RadioSpacingNone.TabStop = true;
            this.RadioSpacingNone.Text = "Brak";
            this.RadioSpacingNone.UseVisualStyleBackColor = true;
            this.RadioSpacingNone.CheckedChanged += new System.EventHandler(this.RadioSpacingNone_CheckedChanged);
            // 
            // stripOverview
            // 
            this.stripOverview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stripOverview.AutoScroll = true;
            this.stripOverview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stripOverview.Location = new System.Drawing.Point(197, 37);
            this.stripOverview.Name = "stripOverview";
            this.stripOverview.Size = new System.Drawing.Size(217, 452);
            this.stripOverview.TabIndex = 8;
            // 
            // GenerateOverview
            // 
            this.GenerateOverview.Enabled = false;
            this.GenerateOverview.Location = new System.Drawing.Point(12, 372);
            this.GenerateOverview.Name = "GenerateOverview";
            this.GenerateOverview.Size = new System.Drawing.Size(179, 30);
            this.GenerateOverview.TabIndex = 9;
            this.GenerateOverview.Text = "Odśwież podgląd";
            this.GenerateOverview.UseVisualStyleBackColor = true;
            this.GenerateOverview.Click += new System.EventHandler(this.GenerateOverview_Click);
            // 
            // ClearTheListButton
            // 
            this.ClearTheListButton.Enabled = false;
            this.ClearTheListButton.Location = new System.Drawing.Point(12, 61);
            this.ClearTheListButton.Name = "ClearTheListButton";
            this.ClearTheListButton.Size = new System.Drawing.Size(179, 43);
            this.ClearTheListButton.TabIndex = 10;
            this.ClearTheListButton.Text = "Wyczyść listę";
            this.ClearTheListButton.UseVisualStyleBackColor = true;
            this.ClearTheListButton.Click += new System.EventHandler(this.ClearTheListButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Location = new System.Drawing.Point(12, 470);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(86, 20);
            this.InfoButton.TabIndex = 0;
            this.InfoButton.Text = "Pomoc";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // CreditsButton
            // 
            this.CreditsButton.Location = new System.Drawing.Point(105, 470);
            this.CreditsButton.Name = "CreditsButton";
            this.CreditsButton.Size = new System.Drawing.Size(86, 20);
            this.CreditsButton.TabIndex = 11;
            this.CreditsButton.Text = "Credits";
            this.CreditsButton.UseVisualStyleBackColor = true;
            this.CreditsButton.Click += new System.EventHandler(this.CreditsButton_Click);
            // 
            // TextHeight
            // 
            this.TextHeight.BackColor = System.Drawing.SystemColors.Menu;
            this.TextHeight.Location = new System.Drawing.Point(309, 12);
            this.TextHeight.Name = "TextHeight";
            this.TextHeight.Size = new System.Drawing.Size(105, 19);
            this.TextHeight.TabIndex = 0;
            this.TextHeight.Text = "Wysokość: 0";
            // 
            // TextWidth
            // 
            this.TextWidth.BackColor = System.Drawing.SystemColors.Menu;
            this.TextWidth.Location = new System.Drawing.Point(197, 12);
            this.TextWidth.Name = "TextWidth";
            this.TextWidth.Size = new System.Drawing.Size(105, 19);
            this.TextWidth.TabIndex = 1;
            this.TextWidth.Text = "Szerokość: 0";
            // 
            // stripProgressBar
            // 
            this.stripProgressBar.Location = new System.Drawing.Point(12, 441);
            this.stripProgressBar.Name = "stripProgressBar";
            this.stripProgressBar.Size = new System.Drawing.Size(179, 23);
            this.stripProgressBar.Step = 1;
            this.stripProgressBar.TabIndex = 0;
            // 
            // PaskoinatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 499);
            this.Controls.Add(this.stripProgressBar);
            this.Controls.Add(this.TextWidth);
            this.Controls.Add(this.CreditsButton);
            this.Controls.Add(this.TextHeight);
            this.Controls.Add(this.InfoButton);
            this.Controls.Add(this.ClearTheListButton);
            this.Controls.Add(this.GenerateOverview);
            this.Controls.Add(this.stripOverview);
            this.Controls.Add(this.SpacingSetup);
            this.Controls.Add(this.WidthSetup);
            this.Controls.Add(this.CreateStripButton);
            this.Controls.Add(this.AddFileButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(440, 2000);
            this.MinimumSize = new System.Drawing.Size(440, 538);
            this.Name = "PaskoinatorForm";
            this.Text = "Paskoinator 5.3";
            this.Load += new System.EventHandler(this.Paskoinator_Load);
            this.WidthSetup.ResumeLayout(false);
            this.WidthSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthInput)).EndInit();
            this.SpacingSetup.ResumeLayout(false);
            this.SpacingSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpacingColorShower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpacingHandInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpacingPercentInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.Button CreateStripButton;
        private System.Windows.Forms.RadioButton RadioWidthMin;
        private System.Windows.Forms.RadioButton RadioWidthAvg;
        private System.Windows.Forms.RadioButton RadioWidthMax;
        private System.Windows.Forms.RadioButton RadioWidthUser;
        private System.Windows.Forms.GroupBox WidthSetup;
        private System.Windows.Forms.NumericUpDown WidthInput;
        private System.Windows.Forms.GroupBox SpacingSetup;
        private System.Windows.Forms.RadioButton RadioSpacingUser;
        private System.Windows.Forms.RadioButton RadioSpacingPercent;
        private System.Windows.Forms.RadioButton RadioSpacingNone;
        private System.Windows.Forms.NumericUpDown SpacingPercentInput;
        private System.Windows.Forms.NumericUpDown SpacingHandInput;
        private System.Windows.Forms.Button SpacingColorButton;
        private System.Windows.Forms.PictureBox SpacingColorShower;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel stripOverview;
        private System.Windows.Forms.Button GenerateOverview;
        private System.Windows.Forms.Button ClearTheListButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Button CreditsButton;
        private System.Windows.Forms.RichTextBox TextHeight;
        private System.Windows.Forms.RichTextBox TextWidth;
        private System.Windows.Forms.ProgressBar stripProgressBar;
    }
}

