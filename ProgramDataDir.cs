using System;
using System.IO;

namespace FortniteAutoclicker
{
    public static class ProgramDataDir
    {
        public enum Line { LastMailTime }

        const string InfoTextFileName = "Info";
        const string DirName = "EditClicker Data";
        static readonly string DirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), DirName);
        static readonly string InfoTextFilePath = Path.Combine(DirPath, InfoTextFileName);



        public static void WriteInfo(Line line, string info) => Write((byte)line, info, InfoTextFilePath);

        public static bool TryGetInfo(Line line, out string info) => TryRead((byte)line, InfoTextFilePath, out info);

        static bool TryRead(byte line, string path, out string text)
        {
            try
            {
                text = File.ReadAllLines(path)[line];
            }
            catch (Exception e) when (e is FileNotFoundException || e is DirectoryNotFoundException)
            {
                text = null;
            }

            return text != null;
        }

        static void Write(byte line, string text, string path)
        {
            if (!Directory.Exists(DirPath))
                Directory.CreateDirectory(DirPath);

            string[] alreadyExistingLines = { };
            if (File.Exists(path))
                alreadyExistingLines = File.ReadAllLines(path);

            string[] linesToWrite = new string[alreadyExistingLines.Length > line + 1 ? alreadyExistingLines.Length : line + 1];

            for (int i = 0; i < linesToWrite.Length; ++i)
            {
                if (i == line)
                    linesToWrite[i] = text;
                else
                    linesToWrite[i] = alreadyExistingLines.Length <= i ? "" : alreadyExistingLines[i];
            }

            File.WriteAllLines(path, linesToWrite);
        }
    }
}
