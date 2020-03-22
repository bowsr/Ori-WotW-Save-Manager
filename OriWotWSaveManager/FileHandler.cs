using System;
using System.IO;

namespace OriWotWSaveManager {
    static class FileHandler {
        static readonly string oriSaveLocation = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Ori and the Will of the Wisps\saveFile0.uberstate";
        static readonly string currentDir = Directory.GetCurrentDirectory() + @"\Save Files\";
        static readonly string oriDebugDir = @"C:\moon\";
        static readonly string oriDebugFile = @"wispsDebug.txt";

        public static void ImportSaveFile(string name) {
            string saveFile = currentDir + name + ".uberstate";

            File.Copy(oriSaveLocation, saveFile, true);
        }

        public static void LoadSaveFile(string name) {
            Console.WriteLine(name);
            string saveFile = currentDir + name + ".uberstate";

            File.Copy(saveFile, oriSaveLocation, true);
        }

        public static void RenameSaveFile(string name, string r) {
            string saveFile = currentDir + name + ".uberstate";
            string newFile = currentDir + r + ".uberstate";

            File.Move(saveFile, newFile);
        }

        public static void DeleteSaveFile(string name) {
            string saveFile = currentDir + name + ".uberstate";

            File.Delete(saveFile);
        }

        public static void CreateSaveFileDir() {
            if(!Directory.Exists(currentDir)) {
                Directory.CreateDirectory(currentDir);
            }
        }

        public static void CreateDebugDirAndFile() {
            if(!Directory.Exists(oriDebugDir))
                Directory.CreateDirectory(oriDebugDir);

            File.Create(oriDebugDir + oriDebugFile);
        }

        public static void DeleteDebugFile() {
            File.Delete(oriDebugDir + oriDebugFile);
        }

        public static bool CheckSaveFileExists() => File.Exists(oriSaveLocation);
        public static bool CheckDebugFileExists() => File.Exists(oriDebugDir + oriDebugFile);
        public static string[] GetSaveFileList() => Directory.GetFiles(currentDir);

    }
}
