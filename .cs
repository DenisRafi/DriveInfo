using System.IO;
using static System.Console;

class DR
{
    public static void Main()
    {
        Title = "DriveInfo";
        DriveInfo[] allDrives = DriveInfo.GetDrives();
        foreach (DriveInfo d in allDrives)
        {
            WriteLine("Drive {0}", d.Name);
            WriteLine("  Drive type: {0}", d.DriveType);
            if (d.IsReady == true)
            {
                WriteLine("  Volume label: {0}", d.VolumeLabel);
                WriteLine("  File system: {0}", d.DriveFormat);
                WriteLine(
                    "  Available space to current user:{0, 15} bytes",
                    d.AvailableFreeSpace);

                WriteLine(
                    "  Total available space:          {0, 15} bytes",
                    d.TotalFreeSpace);

                WriteLine(
                    "  Total size of drive:            {0, 15} bytes ",
                    d.TotalSize);
            }
            ReadKey();
        }
    }
}