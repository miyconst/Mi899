using System.IO;
using Mi899.Domain;
using Xunit;
using System.Linq;

namespace Mi899.Data.Tests
{
    public class ModelTests
    {
        private readonly Model _model;

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

            foreach (var id in ids)
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

            foreach (var id in ids)
            {
                Assert.Single(_model.Tools.Where(x => x.Id == id));
            }
        }

        [Fact]
        public void AllImageFilesExist()
        {
            foreach (var link in _model.Motherboards.SelectMany(x => x.Images))
            {
                Assert.True(Path.IsPathRooted(link.Url));
                Assert.True(File.Exists(link.Url));
            }
        }

        [Fact]
        public void AllBiosFilesExist()
        {
            foreach (var pathname in _model.Bioses.Select(x => x.FileName))
            {
                Assert.True(Path.IsPathRooted(pathname));
                Assert.True(File.Exists(pathname));
            }
        }
    }
}
