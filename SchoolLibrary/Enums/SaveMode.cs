namespace SchoolLibrary.Enums
{
    /// <summary>
    /// Specifies the mode for saving data to a file in a data processing context.
    /// </summary>
    public enum SaveMode
    {
        /// <summary>
        /// Create a new file (if the file exists, overwrite it).
        /// </summary>
        CreateNew,

        /// <summary>
        /// Replace an existing file.
        /// </summary>
        Replace,

        /// <summary>
        /// Append data to an existing file.
        /// </summary>
        Append
    }
}