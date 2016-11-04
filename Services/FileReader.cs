using System;
using System.IO;
using System.Linq;

namespace Services
{
    public static class FileReader
    {
        // Gets contents of file if it 'seems' file is not binary
        public static string GetNonBinaryFileContents(string path)
        {
            string contents = String.Empty;

            // Check file exists
            if (!File.Exists(path))
            {
                // Only add to content if no binary characters found
                string text = File.ReadAllText(path);
                if (!ContainsBinaryChars(text))
                {
                    contents = text;
                }
            }

            return contents;
        }

        // Check if given string may have binary characters
        private static bool ContainsBinaryChars(string content)
        {
            return content.Any(ch => char.IsControl(ch) && ch != '\r' && ch != '\n');
        }
    }
}
