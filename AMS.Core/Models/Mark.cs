namespace AMS.Core.Models
{
    public class Mark:Entity
    {
        public int Value { get; set; }
        public string Subject { get; set; }
        public virtual Certificate Certificate { get; set; }
    }
}