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

            var path = GetTempFolderPath();
            var toolFileInfo = new FileInfo(tool.FileName);
            var tempBatFileInfo = new FileInfo(Path.Combine(path, "dump.bat"));
            var dumpFileName = $"{motherboard.Id}-{DateTime.Now:yyyyMMdd-HHmmss}.rom";

            ZipFile.ExtractToDirectory(toolFileInfo.FullName, path);

            using TextWriter writer = new StreamWriter(tempBatFileInfo.FullName);

            WriteScriptHeader(motherboard, tool, writer);
            writer.WriteLine(string.Format(tool.DumpCommand, dumpFileName));
            WriteScriptFooter(writer);

            ProcessStart(path);

            if (autoExecuteScript)
            {
                ProcessStart(tempBatFileInfo.FullName);
            }
        }

        public void Flash([NotNull] IMotherboard motherboard, [NotNull] IBios bios, [NotNull] ITool tool, bool autoExecuteScript)
        {
            if (motherboard == null) 
                throw new ArgumentNullException(nameof(motherboard));
            if (bios == null) 
                throw new ArgumentNullException(nameof(bios));
            if (tool == null) 
                throw new ArgumentNullException(nameof(tool));

            var path = GetTempFolderPath();
            var toolFileInfo = new FileInfo(tool.FileName);
            var tempBatFileInfo = new FileInfo(Path.Combine(path, "flash.bat"));
            string flashFileName = null;

            ZipFile.ExtractToDirectory(toolFileInfo.FullName, path);

            if (bios.IsZipped)
            {
                flashFileName = Path.GetFileNameWithoutExtension(bios.FileName);
                ZipFile.ExtractToDirectory(bios.FileName, path);
            }
            else
            {
                flashFileName = Path.GetFileName(bios.FileName);
                File.Copy(bios.FileName, Path.Combine(path, flashFileName));
            }
            
            using TextWriter writer = new StreamWriter(tempBatFileInfo.FullName);

            WriteScriptHeader(motherboard, bios, tool, writer);
            writer.WriteLine(string.Format(tool.FlashCommand, flashFileName));
            WriteScriptFooter(writer);

            ProcessStart(path);

            if (autoExecuteScript)
            {
                ProcessStart(tempBatFileInfo.FullName);
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
            var path = Path.Combine(Path.GetTempPath(), nameof(Mi899), DateTime.Now.ToString("yyyy.MM.dd-HH.mm.ss"));

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            return path;
        }

        private void ProcessStart(string path)
        {
            var processStartInfo = new ProcessStartInfo(path)
            {
                UseShellExecute = true
            };

            Process.Start(processStartInfo);
        }
    }
}
