using System;

namespace Mi899.Data
{
    public interface IBios
    {
        string Id { get; }
        string Name { get; }
        string[] MotherboardIds { get; }
        string Description { get; }
        string[] Tags { get; }
    }
}
