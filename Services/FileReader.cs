using System;
using System.IO;
using System.Linq;

namespace Services
{
    public static class FileReader
    {
        // Checks if file exists
        public static bool Exists(string path)
        {
            return File.Exists(path);
        }

        // Gets contents of file if it 'seems' file is not binary
        public static string GetNonBinaryContents(string path)
        {
            string contents = String.Empty;

            // Check file exists
            if (File.Exists(path))
            {
                // Only add to content if no binary characters found
                string text = File.ReadAllText(path);
                if (!ContainsBinaryChars(text))
                {
                    contents = text.Substring(0, Math.Min(text.Length, 300));
                    contents += "...";
                }
                else
                {
                    contents = "Unable to read contents";
                }
            }

            return contents;
        }

        // Gets file's last modified datetime
        public static DateTime GetModifiedTime(string path)
        {
            if(File.Exists(path))
            {
                FileInfo info = new FileInfo(path);
                return info.LastWriteTime;
            }
            else
            {
                return DateTime.MinValue;
            }
        }

        // Check if given string may have binary characters
        private static bool ContainsBinaryChars(string content)
        {
            return content.Any(ch => char.IsControl(ch) && ch != '\r' && ch != '\n');
        }
    }
}
