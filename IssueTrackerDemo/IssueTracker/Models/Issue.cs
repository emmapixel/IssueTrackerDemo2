namespace IssueTracker.Models
{
    public class Issue
    {

        // The Id property is the primary key with the uint data type.
        public uint Id { get; set; }


        // The Title is a property with the string data type.
        // The Title has the default value Empty.
        public string Title { get; set; } = string.Empty;


        // The Description is a property with the string data type.
        // The Description has the default value Empty.
        public string Description { get; set; } = string.Empty;


        // Property named IssueType with the enum type named IssueType.
        public IssueType IssueType { get; set; }


        // Property named priority with the enum type named Priority.
        public Priority Priority { get; set; }



        // The Created property with the DateTime type represents the date on which the issue was created.
        public DateTime Created { get; set; }


        
        /*
           The Completed property with the DateTime type represents the date on which the -
           issue was completed. This property will contain either null meaning the is pending,
           or a date time which indicates that it has been resolved.
        */
        public DateTime Completed { get; set; }

    }


    // This enum represents a issue type. 
    public enum IssueType
    {
        Feature,
        Bug,
        Documentation
    }


    // This enum represents a priority type. 
    public enum Priority
    {
        Low,
        Medium,
        High
    }

}
