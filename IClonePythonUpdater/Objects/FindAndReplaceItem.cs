

#region using statements



#endregion

namespace IClonePythonUpdater.Objects
{

    #region class FindAndReplaceItem
    /// <summary>
    /// This class represents a text item to find and the value to replace it with.
    /// </summary>
    public class FindAndReplaceItem
    {
        
        #region Private Variables
        private string find;
        private string replace;
        private string ensureHeaderText;
        #endregion

        #region Properties

            #region EnsureHeaderText
            /// <summary>
            /// This property gets or sets the value for 'EnsureHeaderText'.
            /// </summary>
            public string EnsureHeaderText
            {
                get { return ensureHeaderText; }
                set { ensureHeaderText = value; }
            }
            #endregion
            
            #region Find
            /// <summary>
            /// This property gets or sets the value for 'Find'.
            /// </summary>
            public string Find
            {
                get { return find; }
                set { find = value; }
            }
            #endregion
            
            #region Replace
            /// <summary>
            /// This property gets or sets the value for 'Replace'.
            /// </summary>
            public string Replace
            {
                get { return replace; }
                set { replace = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
