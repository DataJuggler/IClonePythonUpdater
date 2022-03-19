

#region using statements

using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using DataJuggler.UltimateHelper;
using DataJuggler.UltimateHelper.Objects;
using IClonePythonUpdater.Objects;

#endregion

namespace IClonePythonUpdater
{

    #region class MainForm
    /// <summary>
    /// This is the MainForm for this app
    /// </summary>
    public partial class MainForm : Form, ITextChanged
    {
        
        #region Private Variables
        private string sourceFile;
        private string outputFolder;
        private List<FindAndReplaceItem> findAndReplaceItems;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion
        
        #region Events
            
            #region ConvertButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ConvertButton' is clicked.
            /// </summary>
            private void ConvertButton_Click(object sender, EventArgs e)
            {
                // locals
                List<TextLine> lines = null;
                int replacementsMade = 0;
                string newFileText = "";
                FileInfo sourceFileInfo = null;

                // If the SourceFile Exists On Disk
                if (FileHelper.Exists(SourceFile))
                {
                    // read the file
                    string fileText = File.ReadAllText(SourceFile);

                    // If the fileText string exists
                    if (TextHelper.Exists(fileText))
                    {  
                        // get the text lines
                        lines = TextHelper.GetTextLines(fileText);
                    }

                    // Load the Find And Replace Items
                    LoadFindAndReplaceItems();

                    // If the FindAndReplaceItems and lines collections exist and each have one or more items
                    if (ListHelper.HasOneOrMoreItems(FindAndReplaceItems, lines))
                    {
                        // Setup the Graph
                        Graph.Maximum = FindAndReplaceItems.Count;
                        Graph.Value = 0;
                        Graph.Visible = true;

                        // find the first blank line
                        int firstBlankLine = FindFirstBlankLineIndex(lines);

                        // if the first blank line was found
                        if (firstBlankLine > 0)
                        {
                            // insert this for every conversion
                            TextLine blankLine = new TextLine("");
                            TextLine textLine = new TextLine("ap_version=RLPy.RApplication.GetProductVersion()[0]");
                            TextLine textLine2 = new TextLine("if ap_version == 7:");
                            TextLine textLine3 = new TextLine("    rl_plugin_info = {\"ap\": \"iClone\", \"ap_version\": \"7.0\"}");
                            TextLine textLine4 = new TextLine("if ap_version == 8:");
                            TextLine textLine5 = new TextLine("    rl_plugin_info = {\"ap\": \"iClone\", \"ap_version\": \"8.0\"}");

                            // insert in reverse order                            
                            lines.Insert(firstBlankLine, textLine5);
                            lines.Insert(firstBlankLine, textLine4);
                            lines.Insert(firstBlankLine, textLine3);
                            lines.Insert(firstBlankLine, textLine2);
                            lines.Insert(firstBlankLine, textLine);                            
                            lines.Insert(firstBlankLine, blankLine);

                            // We have made replacements
                            replacementsMade++;
                        }

                        // Iterate the collection of FindAndReplaceItem objects
                        foreach (FindAndReplaceItem item in FindAndReplaceItems)
                        {
                            // Iterate the collection of TextLine objects
                            foreach (TextLine line in lines)
                            {
                                // if the line contains the text to find
                                if (line.Text.Contains(item.Find))
                                {
                                    // Display the output changes
                                    OutputListBox.Items.Add("Before: " + line.Text);

                                    // Execute the Find and Replace
                                    line.Text = line.Text.Replace(item.Find, item.Replace);

                                    // Display the output changes
                                    OutputListBox.Items.Add("After: " + line.Text);

                                    // Increment the value for replacementsMade
                                    replacementsMade++;
                                }
                            }

                            // Increment the value for Graph
                            Graph.Value++;
                        }

                        // If the value for replacementsMade is greater than zero
                        if (replacementsMade > 0)
                        {
                            // Get the newFileText
                            newFileText = TextHelper.ExportTextLines(lines);

                            // Get the SourceFileInfo
                            sourceFileInfo = new FileInfo(SourceFile);

                            // Get the FileName Only
                            string outputFile = Path.Combine(OutputFolder, sourceFileInfo.Name);

                            // Write out the text
                            File.WriteAllText(outputFile, newFileText);

                            // Show the results
                            StatusLabel.Text = "Finished Converting " + sourceFileInfo.Name + " - Replacements Made: " + replacementsMade;
                        }
                    }
                }
            }
            #endregion
            
            #region OnTextChanged(Control sender, string text)
            /// <summary>
            /// event is fired when On Text Changed
            /// </summary>
            public void OnTextChanged(Control sender, string text)
            {
                // if this is the SourceFile control and the text exists
                if ((sender.Name == SourceFileControl.Name) && (TextHelper.Exists(text)))
                {
                    // Set the SourceFile
                    SourceFile = text;

                    // if the OutputFolder has text, than we are ready to convert
                    if (OutputFolderControl.HasText)
                    {
                        // Change the text
                        StatusLabel.Text = "Click Convert";
                    }
                    else
                    {
                        // Change the text
                        StatusLabel.Text = "Select Output Folder";
                    }
                }
                else if ((sender.Name == OutputFolderControl.Name) && (TextHelper.Exists(text)))
                {
                    // Set the Output Folder
                    OutputFolder = text;

                    // Change the text
                    StatusLabel.Text = "Click Convert";
                }

                // Enable or disable controls
                UIEnable();
            }
            #endregion
            
        #endregion

         #region Methods
            
            #region FindFirstBlankLineIndex(List<TextLine> lines)
            /// <summary>
            /// returns the First Blank Line Index
            /// </summary>
            public int FindFirstBlankLineIndex(List<TextLine> lines)
            {
                // initial value
                int firstBlankLineIndex = -1;

                // local
                int index = -1;

                // If the lines collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(lines))
                {
                    // Iterate the collection of TextLine objects
                    foreach (TextLine line in lines)
                    {
                        // Increment the value for index
                        index++;

                        // if this line is blank
                        if (line.Text.Trim().Length == 0)
                        {
                            // set the return value
                            firstBlankLineIndex = index;

                            // break out of loop
                            break;
                        }
                    }
                }
                
                // return value
                return firstBlankLineIndex;
            }
            #endregion
            
            #region Init()
            /// <summary>
            ///  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Setup the listeners
                SourceFileControl.OnTextChangedListener = this;
                OutputFolderControl.OnTextChangedListener = this;

                // Setup the Output Folder
                OutputFolderControl.Text = ConfigurationHelper.ReadAppSetting("OutputFolder");

                // Set the StartPath
                SourceFileControl.StartPath = ConfigurationHelper.ReadAppSetting("SourceFile");

                // Setup the Output Folder
                OutputFolderControl.StartPath = OutputFolderControl.Text;
            }
            #endregion
            
            #region LoadFindAndReplaceItems()
            /// <summary>
            /// Load Find And Replace Items
            /// </summary>
            public void LoadFindAndReplaceItems()
            {
                // Create each item
                FindAndReplaceItems = new List<FindAndReplaceItem>();

                ////////////////////////////////////////////////////////////////////////////
                ////////  from PySide2.shiboken2 import wrapInstance             ////////
                ////////////////////////////////////////////////////////////////////////////

                // Create a new instance of a 'FindAndReplaceItem' object.
                FindAndReplaceItem findAndReplaceItem = new FindAndReplaceItem();
                findAndReplaceItem.Find = "from PySide2.shiboken2 import wrapInstance";
                findAndReplaceItem.Replace = "from shiboken2 import wrapInstance";

                // Add this item
                FindAndReplaceItems.Add(findAndReplaceItem);

                ////////////////////////////////////////////////////////////////////////////
                ////////                RLPy.RTime(                                            ////////
                ////////////////////////////////////////////////////////////////////////////

                // Create a new instance of a 'FindAndReplaceItem' object.
                findAndReplaceItem = new FindAndReplaceItem();
                findAndReplaceItem.Find = "RTime(";
                findAndReplaceItem.Replace = "RTime.FromValue(";

                // Add this item
                FindAndReplaceItems.Add(findAndReplaceItem);

                ////////////////////////////////////////////////////////////////////////////
                ////////                RLPy.RTime.GetFrameIndex                        ////////
                ////////////////////////////////////////////////////////////////////////////

                // Create a new instance of a 'FindAndReplaceItem' object.
                findAndReplaceItem = new FindAndReplaceItem();
                findAndReplaceItem.Find = "RLPy.RTime.GetFrameIndex";
                findAndReplaceItem.Replace = "RLPy.GetFrameIndex";

                // Add this item
                FindAndReplaceItems.Add(findAndReplaceItem);

                ////////////////////////////////////////////////////////////////////////////
                ////////             RLPy.RTime().IndexedFrameTime                   ////////
                ////////////////////////////////////////////////////////////////////////////

                // Create a new instance of a 'FindAndReplaceItem' object.
                findAndReplaceItem = new FindAndReplaceItem();
                findAndReplaceItem.Find = "RLPy.RTime().IndexedFrameTime";
                findAndReplaceItem.Replace = "RLPy.IndexedFrameTime";

                // Add this item
                FindAndReplaceItems.Add(findAndReplaceItem);

                ////////////////////////////////////////////////////////////////////////////
                ////////                   RLPy.RMath.Ceil( )                                 ////////
                ////////////////////////////////////////////////////////////////////////////

                // Create a new instance of a 'FindAndReplaceItem' object.
                findAndReplaceItem = new FindAndReplaceItem();
                findAndReplaceItem.Find = "RLPy.RMath.Ceil()";
                findAndReplaceItem.Replace = "ceil";
                findAndReplaceItem.EnsureHeaderText = "from math import *";

                // Add this item
                FindAndReplaceItems.Add(findAndReplaceItem);

                ////////////////////////////////////////////////////////////////////////////
                ////////           GetMotionBones()                                         ////////
                ////////////////////////////////////////////////////////////////////////////

                // Create a new instance of a 'FindAndReplaceItem' object.
                findAndReplaceItem = new FindAndReplaceItem();
                findAndReplaceItem.Find = "GetMotionBones()";
                findAndReplaceItem.Replace = "GetSkinBones";
                
                 // Add this item
                FindAndReplaceItems.Add(findAndReplaceItem);

                ////////////////////////////////////////////////////////////////////////////
                ////////        GetHikEffectorComponent()                               ////////
                ////////////////////////////////////////////////////////////////////////////

                // Create a new instance of a 'FindAndReplaceItem' object.
                findAndReplaceItem = new FindAndReplaceItem();
                findAndReplaceItem.Find = "GetHikEffectorComponent()";
                findAndReplaceItem.Replace = "GetIC7HikEffectorComponent()";
                
                 // Add this item
                FindAndReplaceItems.Add(findAndReplaceItem);
            }
            #endregion
            
            #region UIEnable()
            /// <summary>
            /// UI Enable
            /// </summary>
            public void UIEnable()
            {
                // Enable the button
                ConvertButton.Enabled = (HasOutputFolder) && (HasSourceFile);

                // Update the UI
                Refresh();
            }
            #endregion
            
        #endregion

        #region Properties

            #region FindAndReplaceItems
            /// <summary>
            /// This property gets or sets the value for 'FindAndReplaceItems'.
            /// </summary>
            public List<FindAndReplaceItem> FindAndReplaceItems
            {
                get { return findAndReplaceItems; }
                set { findAndReplaceItems = value; }
            }
            #endregion
            
            #region HasOutputFolder
            /// <summary>
            /// This property returns true if the 'OutputFolder' exists.
            /// </summary>
            public bool HasOutputFolder
            {
                get
                {
                    // initial value
                    bool hasOutputFolder = (!String.IsNullOrEmpty(this.OutputFolder));
                    
                    // return value
                    return hasOutputFolder;
                }
            }
            #endregion
            
            #region HasSourceFile
            /// <summary>
            /// This property returns true if the 'SourceFile' exists.
            /// </summary>
            public bool HasSourceFile
            {
                get
                {
                    // initial value
                    bool hasSourceFile = (!String.IsNullOrEmpty(this.SourceFile));
                    
                    // return value
                    return hasSourceFile;
                }
            }
            #endregion
            
            #region OutputFolder
            /// <summary>
            /// This property gets or sets the value for 'OutputFolder'.
            /// </summary>
            public string OutputFolder
            {
                get { return outputFolder; }
                set { outputFolder = value; }
            }
            #endregion
            
            #region SourceFile
            /// <summary>
            /// This property gets or sets the value for 'SourceFile'.
            /// </summary>
            public string SourceFile
            {
                get { return sourceFile; }
                set { sourceFile = value; }
            }
            #endregion

        #endregion
    }
    #endregion

}
