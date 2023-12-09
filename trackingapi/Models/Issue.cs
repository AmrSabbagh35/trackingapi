namespace trackingapi.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public int Title { get; set; }

        public int Desc { get; set; }

        public Priority Priority { get; set; }

        public IssueType IssueType { get; set; }

    }

    public enum Priority
    {
        Low,Medium,High
    }

    public enum IssueType
    {
        Feature,Bug,Documentation
    }
}
