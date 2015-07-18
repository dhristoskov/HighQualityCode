using System;

namespace CohesionAndCoupling.Utils
{
    /// <summary>
    /// Class that holds file operation
    /// </summary>
    static class FileUtil
    {
        /// <summary>
        /// Method that return only file extenesion
        /// if there is not file extension returns 
        /// empty string.
        /// </summary>
        /// <param name="fileName">string represent a file name</param>
        /// <returns>file extansion only</returns>
        public static string GetFileExtension(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException(nameof(fileName), "File is null!");
            }

            int indexOfLastDot = fileName.LastIndexOf(".", StringComparison.Ordinal);
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        /// <summary>
        /// Method that return only file name
        /// if there is not file throws an
        /// exception
        /// </summary>
        /// <param name="fileName">string represent a file name</param>
        /// <returns>file name without extension</returns>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            if (fileName == null)
            {
                throw new ArgumentNullException(nameof(fileName), "File is null!");
            }

            int indexOfLastDot = fileName.LastIndexOf(".", StringComparison.Ordinal);
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
