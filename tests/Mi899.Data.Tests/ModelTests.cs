using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Xunit;
using System.Threading.Tasks;
using System.Net.Http;

namespace Mi899.Data.Tests
{
    public class ModelTests
    {
        private Model _model;

        public ModelTests()
        {
            _model = Model.LoadFromJson();
        }

        [Fact]
        public void IsNotEmpty()
        {
            Assert.NotNull(_model);
            Assert.NotEmpty(_model.Motherboards);
            Assert.NotEmpty(_model.Bioses);
        }

        [Fact]
        public void AllIdsAreUnique()
        {
            var ids = _model.Motherboards.Select(x => x.Id)
                .Union(_model.Bioses.Select(x => x.Id))
                .Union(_model.Tools.Select(x => x.Id))
                .GroupBy(x => x)
                .ToList();

            foreach (var g in ids)
            {
                Assert.Single(g);
            }
        }

        [Fact]
        public void AllBiosMotherboardIdsAreValid()
        {
            var ids = _model
                .Bioses
                .SelectMany(x => x.MotherboardIds)
                .Distinct();

            foreach (string id in ids)
            {
                Assert.Single(_model.Motherboards.Where(x => x.Id == id));
            }
        }

        [Fact]
        public void AllMotherboardToolIdsAreValid()
        {
            var ids = _model.Motherboards
                .SelectMany(x => x.ToolIds)
                .Distinct();

            foreach (string id in ids)
            {
                Assert.Single(_model.Tools.Where(x => x.Id == id));
            }
        }

        [Fact]
        public void AllImageFilesExist()
        {
            foreach (ILink link in _model.Motherboards.SelectMany(x => x.Images))
            {
                Assert.True(Path.IsPathRooted(link.Url));
                Assert.True(File.Exists(link.Url));
            }
        }

        [Fact]
        public async Task AllBiosFilesExist()
        {
            using HttpClient client = new HttpClient();

            foreach (IBios bios in _model.Bioses)
            {
                if (bios.IsCommercial)
                    continue;

                string pathname = bios.FileName;

                Assert.True(Path.IsPathRooted(pathname));
                Assert.NotEmpty(bios.DownloadUrl);

                using MemoryStream ms = new MemoryStream();

                try
                {
                    using Stream steam = await client.GetStreamAsync(bios.DownloadUrl);

                    steam.CopyTo(ms);
                    Assert.True(ms.Length > 0);
                }
                catch (Exception ex)
                {
                    throw new Exception("Failed to download BIOS with URL: " + bios.DownloadUrl, ex);
                }
            }
        }
    }
}
