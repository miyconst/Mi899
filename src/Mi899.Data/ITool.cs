namespace Mi899.Data
{
    public interface ITool
    {
        string Id { get; }
        string Name { get; }
        string Version { get; }
        string DumpCommand { get; }
        string FlashCommand { get; }
        string FileName { get; }
    }
}
