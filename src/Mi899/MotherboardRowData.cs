using Mi899.Data;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;

namespace Mi899
{
    public class MotherboardRowData : IMotherboard
    {
        public MotherboardRowData([NotNull] IMotherboard source)
        {
            Source = source ?? throw new ArgumentNullException(nameof(source));
        }

        public IMotherboard Source { get; private set; }

        public string Id => Source.Id;

        public string Name => Source.Name;

        public string Brand => Source.Brand;

        public string Model => Source.Model;

        public string Version => Source.Version;

        public string[] Tags => Source.Tags;

        public string TagsString => string.Join(", ", Tags);

        public string Description => Source.Description;

        public ILink[] Images => Source.Images;

        public ILink[] Links => Source.Links;

        public string[] ToolIds => Source.ToolIds;

        public Bitmap DefaultImage
        {
            get
            {
                var link = Images.FirstOrDefault();

                if (link == null)
                {
                    return null;
                }

                var bmp = new Bitmap(link.Url);

                return bmp;
            }
        }
    }
}
