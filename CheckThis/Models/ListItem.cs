using System;

namespace CheckThisData.Models
{
    public class ListItem
    {
        public string ItemName { get; set; }
        public string Notes { get; set; }
        public int? SortOrder { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? DidItDate { get; set; }
        public string PhotoId { get; set; }
    }
}
