using System.Collections.Generic;

namespace StarTrek.Models
{
    public class TrekEvent
    {
        public TrekEvent()
        {
            this.Characters = new HashSet<Character>();
        }
        public int TrekEventId { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Date { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
    }
}