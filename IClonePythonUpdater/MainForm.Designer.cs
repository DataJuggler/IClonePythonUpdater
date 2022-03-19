namespace IClonePythonUpdater
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SourceFileControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.OutputFolderControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.ConvertButton = new DataJuggler.Win.Controls.Button();
            this.HiddenButton = new DataJuggler.Win.Controls.Button();
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.OutputListBox = new System.Windows.Forms.ListBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SourceFileControl
            // 
            this.SourceFileControl.BackColor = System.Drawing.Color.Transparent;
            this.SourceFileControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.SourceFileControl.ButtonColor = System.Drawing.Color.LemonChiffon;
            this.SourceFileControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("SourceFileControl.ButtonImage")));
            this.SourceFileControl.ButtonWidth = 48;
            this.SourceFileControl.DarkMode = false;
            this.SourceFileControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.SourceFileControl.Editable = true;
            this.SourceFileControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.SourceFileControl.Filter = null;
            this.SourceFileControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceFileControl.HideBrowseButton = false;
            this.SourceFileControl.LabelBottomMargin = 0;
            this.SourceFileControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SourceFileControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SourceFileControl.LabelText = "Source File:";
            this.SourceFileControl.LabelTopMargin = 0;
            this.SourceFileControl.LabelWidth = 140;
            this.SourceFileControl.Location = new System.Drawing.Point(40, 52);
            this.SourceFileControl.Name = "SourceFileControl";
            this.SourceFileControl.OnTextChangedListener = null;
            this.SourceFileControl.OpenCallback = null;
            this.SourceFileControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SourceFileControl.SelectedPath = null;
            this.SourceFileControl.Size = new System.Drawing.Size(729, 32);
            this.SourceFileControl.StartPath = null;
            this.SourceFileControl.TabIndex = 0;
            this.SourceFileControl.TextBoxBottomMargin = 0;
            this.SourceFileControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.SourceFileControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.SourceFileControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceFileControl.TextBoxTopMargin = 0;
            this.SourceFileControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // OutputFolderControl
            // 
            this.OutputFolderControl.BackColor = System.Drawing.Color.Transparent;
            this.OutputFolderControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            this.OutputFolderControl.ButtonColor = System.Drawing.Color.LemonChiffon;
            this.OutputFolderControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("OutputFolderControl.ButtonImage")));
            this.OutputFolderControl.ButtonWidth = 48;
            this.OutputFolderControl.DarkMode = false;
            this.OutputFolderControl.DisabledLabelColor = System.Drawing.Color.Empty;
            this.OutputFolderControl.Editable = true;
            this.OutputFolderControl.EnabledLabelColor = System.Drawing.Color.Empty;
            this.OutputFolderControl.Filter = null;
            this.OutputFolderControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputFolderControl.HideBrowseButton = false;
            this.OutputFolderControl.LabelBottomMargin = 0;
            this.OutputFolderControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.OutputFolderControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutputFolderControl.LabelText = "Output Folder:";
            this.OutputFolderControl.LabelTopMargin = 0;
            this.OutputFolderControl.LabelWidth = 140;
            this.OutputFolderControl.Location = new System.Drawing.Point(40, 120);
            this.OutputFolderControl.Name = "OutputFolderControl";
            this.OutputFolderControl.OnTextChangedListener = null;
            this.OutputFolderControl.OpenCallback = null;
            this.OutputFolderControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OutputFolderControl.SelectedPath = null;
            this.OutputFolderControl.Size = new System.Drawing.Size(729, 32);
            this.OutputFolderControl.StartPath = null;
            this.OutputFolderControl.TabIndex = 1;
            this.OutputFolderControl.TextBoxBottomMargin = 0;
            this.OutputFolderControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.OutputFolderControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.OutputFolderControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputFolderControl.TextBoxTopMargin = 0;
            this.OutputFolderControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ConvertButton
            // 
            this.ConvertButton.BackColor = System.Drawing.Color.Transparent;
            this.ConvertButton.ButtonText = "Convert";
            this.ConvertButton.Enabled = false;
            this.ConvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConvertButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ConvertButton.Location = new System.Drawing.Point(649, 191);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(120, 44);
            this.ConvertButton.TabIndex = 2;
            this.ConvertButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // HiddenButton
            // 
            this.HiddenButton.BackColor = System.Drawing.Color.Transparent;
            this.HiddenButton.ButtonText = "Hidden";
            this.HiddenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HiddenButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.HiddenButton.Location = new System.Drawing.Point(-523, 191);
            this.HiddenButton.Name = "HiddenButton";
            this.HiddenButton.Size = new System.Drawing.Size(120, 44);
            this.HiddenButton.TabIndex = 3;
            this.HiddenButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(40, 400);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(735, 23);
            this.Graph.TabIndex = 4;
            this.Graph.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StatusLabel.Location = new System.Drawing.Point(40, 372);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(735, 23);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Select Source File";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            this.OutputListBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputListBox.FormattingEnabled = true;
            this.OutputListBox.ItemHeight = 18;
            this.OutputListBox.Location = new System.Drawing.Point(40, 191);
            this.OutputListBox.Name = "listBox1";
            this.OutputListBox.Size = new System.Drawing.Size(468, 148);
            this.OutputListBox.TabIndex = 6;
            // 
            // OutputLabel
            // 
            this.OutputLabel.BackColor = System.Drawing.Color.Transparent;
            this.OutputLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.OutputLabel.Location = new System.Drawing.Point(40, 165);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(82, 23);
            this.OutputLabel.TabIndex = 7;
            this.OutputLabel.Text = "Output";
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::IClonePythonUpdater.Properties.Resources.BlackImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.OutputListBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.HiddenButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.OutputFolderControl);
            this.Controls.Add(this.SourceFileControl);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IClonel 8 Python Updater";
            this.ResumeLayout(false);

        }

        #endregion

        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl SourceFileControl;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl OutputFolderControl;
        private DataJuggler.Win.Controls.Button ConvertButton;
        private DataJuggler.Win.Controls.Button HiddenButton;
        private ProgressBar Graph;
        private Label StatusLabel;
        private ListBox OutputListBox;
        private Label OutputLabel;
    }
}