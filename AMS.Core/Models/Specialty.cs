namespace AMS.Core.Models
{
    public class Specialty : Entity
    {
        public string Name { get; set; }
        public virtual Application Application { get; set; }
        public virtual University University { get; set; }
    }
}