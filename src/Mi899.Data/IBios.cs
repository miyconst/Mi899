using System;
using System.Collections.Generic;

namespace Mi899.Data
{
    public interface IBios
    {
        string Id { get; }
        string Name { get; }
        string[] MotherboardIds { get; }
        string Description { get; }
        string[] Tags { get; }
        string FileName { get; }
        IReadOnlyDictionary<string, string> Properties { get; }
        string[] Chipsets { get; }
    }
}
