namespace PoSS.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public DateTime DateHired { get; set; }
        public DateTime DateDeleted { get; set; }
    }
}
