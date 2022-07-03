using System;
using System.IO;

namespace DailyProject
{
    static class PathDefinition
    {
        public static string RootPath = AppDomain.CurrentDomain.BaseDirectory;

        public static string DailyJsonDirectoryPath = Path.Combine(RootPath, "Data\\Day");
    }
}
