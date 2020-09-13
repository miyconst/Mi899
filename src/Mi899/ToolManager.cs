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

            string path = GetTempFolderPath();
            FileInfo toolFi = new FileInfo(tool.FileName);
            FileInfo tempBatFi = new FileInfo(Path.Combine(path, "dump.bat"));
            string dumpFileName = $"{motherboard.Id}-{DateTime.Now:yyyyMMdd-HHmmss}.rom";

            ZipFile.ExtractToDirectory(toolFi.FullName, path);

            using TextWriter writer = new StreamWriter(tempBatFi.FullName);

            WriteScriptHeader(motherboard, tool, writer);
            writer.WriteLine(string.Format(tool.DumpCommand, dumpFileName));
            WriteScriptFooter(writer);

            ProcessStart(path);

            if (autoExecuteScript)
            {
                ProcessStart(tempBatFi.FullName);
            }
        }

        public void Flash([NotNull] IMotherboard motherboard, [NotNull] IBios bios, [NotNull] ITool tool, bool autoExecuteScript)
        {
            if (motherboard == null) throw new ArgumentNullException(nameof(motherboard));
            if (bios == null) throw new ArgumentNullException(nameof(bios));
            if (tool == null) throw new ArgumentNullException(nameof(tool));

            string path = GetTempFolderPath();
            FileInfo toolFi = new FileInfo(tool.FileName);
            FileInfo tempBatFi = new FileInfo(Path.Combine(path, "flash.bat"));
            string flashFileName = Path.GetFileNameWithoutExtension(bios.FileName);

            ZipFile.ExtractToDirectory(toolFi.FullName, path);
            ZipFile.ExtractToDirectory(bios.FileName, path); using TextWriter writer = new StreamWriter(tempBatFi.FullName);

            WriteScriptHeader(motherboard, bios, tool, writer);
            writer.WriteLine(string.Format(tool.FlashCommand, flashFileName));
            WriteScriptFooter(writer);

            ProcessStart(path);

            if (autoExecuteScript)
            {
                ProcessStart(tempBatFi.FullName);
            }
        }

        private void WriteScriptHeader(IMotherboard motherboard, ITool tool, TextWriter writer)
        {
            WriteScriptHeader(motherboard, null, tool, writer);
        }

        private void WriteScriptHeader(IMotherboard motherboard, IBios bios, ITool tool, TextWriter writer)
        {
            writer.WriteLine("@echo off");
            writer.WriteLine($":: {nameof(Mi899)} - {DateTime.Now:yyyy.MM.dd} {DateTime.Now:HH:mm:ss}");
            writer.WriteLine($":: Motherboard: {motherboard.Name} {motherboard.Version}");

            if (bios != null)
            {
                writer.WriteLine($":: BIOS: {bios.Name}");
            }

            writer.WriteLine($":: Tool: {tool.Name} {tool.Version}");
            writer.WriteLine();
            writer.WriteLine("cd /d %~dp0");
        }

        private void WriteScriptFooter(TextWriter writer)
        {
            writer.WriteLine($"echo Thank you for using {nameof(Mi899)}.");
            writer.WriteLine("PAUSE");
        }

        private string GetTempFolderPath()
        {
            string path = Path.Combine(Path.GetTempPath(), nameof(Mi899), DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss"));

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return path;
        }

        private void ProcessStart(string path)
        {
            ProcessStartInfo psi = new ProcessStartInfo(path)
            {
                UseShellExecute = true
            };

            Process.Start(psi);
        }
    }
}
