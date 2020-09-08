using System;

namespace Mi899.Data
{
    public interface IMotherboard
    {
        string Id { get; }
        string Name { get; }
        string Brand { get; }
        string Model { get; }
        string Version { get; }
        string[] Tags { get; }
        string TagsString { get; }
        string Description { get; }
        ILink[] Images { get; }
        ILink[] Links { get; }
        bool IsFptCompatible { get; }
        bool IsAfuWinCompatible { get; }
    }
}
