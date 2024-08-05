namespace Yasapp.Shared
{
    public class YasappException : Exception
    {
        public YasappException(string title)
            : base()
        {
            Title = title;
            Messages = new List<string>();
        }

        public YasappException(string title, string description)
            : this(title)
        {
            Description = description;
        }

        public void AddMessage(string Message)
        {
            Messages?.Add(Message);
        }

        public string Severity { get; set; }

        public bool HasErrors() => Messages?.Count > 0;

        public List<string>? Messages { get; set; }

        public string? PlaceOfOccurence { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }

    }
}
