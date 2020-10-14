using System;
using static System.Console;
using System.IO;
using static System.IO.Directory;
using static System.Environment;
using static System.IO.Path;


namespace FilesSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"PathSeparator : {Path.PathSeparator}");
            WriteLine($"DirectorySeparatorChar : {Path.DirectorySeparatorChar}");
            WriteLine($"CurrentDirectory : {Directory.GetCurrentDirectory()}");
            WriteLine($"Environment.CurrentDirectory : {Environment.CurrentDirectory}");
            WriteLine($"Environment.SystemDirecotry : {Environment.SystemDirectory}");
            WriteLine($"Path.GetTempPath() : {Path.GetTempPath()}");

            WriteLine($"GetFolderPath(System) : {GetFolderPath(SpecialFolder.System)}");
            WriteLine($"GetFolderPath(System) : {GetFolderPath(SpecialFolder.ApplicationData)}");
            WriteLine($"GetFolderPath(System) : {GetFolderPath(SpecialFolder.MyDocuments)}");
            WriteLine($"GetFolderPath(System) : {GetFolderPath(SpecialFolder.Personal)}");

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                WriteLine($"{drive.Name} {drive.DriveType} {drive.DriveFormat} {drive.TotalSize:N0} {drive.AvailableFreeSpace:N0}");
            }

        }
    }
}
