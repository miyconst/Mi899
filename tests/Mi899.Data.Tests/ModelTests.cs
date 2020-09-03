using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using Xunit;

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
        public void AllImageFilesExist()
        {
            foreach (ILink link in _model.Motherboards.SelectMany(x => x.Images))
            {
                Assert.True(Path.IsPathRooted(link.Url));
                Assert.True(File.Exists(link.Url));
            }
        }

        [Fact]
        public void AllBiosFilesExist()
        {
            foreach (string pathname in _model.Bioses.Select(x => x.FileName))
            {
                Assert.True(Path.IsPathRooted(pathname));
                Assert.True(File.Exists(pathname));
            }
        }
    }
}
