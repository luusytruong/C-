namespace review_test;
class Book35
{
    public string? Title { get; set; }
    public string? Author { get; set; }
    public Book35(string title, string author)
    {
        Title = title;
        Author = author;
    }
}
//2
class DataProcess35
{
    public event Action? OnDataProcessed;
    public void ProcessData()
    {
        OnDataProcessed?.Invoke();
    }
}