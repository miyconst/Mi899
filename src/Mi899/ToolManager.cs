using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics.CodeAnalysis;
using Mi899.Data;
using System.IO.Compression;
using System.Diagnostics;

namespace Mi899
{
    public class ToolManager
    {
        public void Dump([NotNull] IMotherboard motherboard, [NotNull] ITool tool, bool autoExecuteScript)
        {
            if (motherboard == null) throw new ArgumentNullException(nameof(motherboard));
            if (tool == null) throw new ArgumentNullException(nameof(tool));

            string path = Path.Combine(Path.GetTempPath(), nameof(Mi899), DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss"));

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            FileInfo toolFi = new FileInfo(tool.FileName);
            FileInfo tempBatFi = new FileInfo(Path.Combine(path, "dump.bat"));
            string dumpFileName = $"{motherboard.Id}-{DateTime.Now:yyyyMMdd-HHmmss}.rom";

            ZipFile.ExtractToDirectory(toolFi.FullName, path);

            using TextWriter writer = new StreamWriter(tempBatFi.FullName);

            writer.WriteLine($":: {nameof(Mi899)} - {DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}");
            writer.WriteLine($":: {motherboard.Name} {motherboard.Version}");
            writer.WriteLine($":: {tool.Name} {tool.Version}");
            writer.WriteLine();
            writer.WriteLine("cd /d %~dp0");
            writer.WriteLine(string.Format(tool.DumpCommand, dumpFileName));
            writer.WriteLine("PAUSE");

            ProcessStartInfo psi = new ProcessStartInfo(path)
            {
                UseShellExecute = true
            };

            Process.Start(psi);
        }
    }
}
