namespace PoSS.DTOs
{
    public class EmployeeDTO
    {
        /// <summary>
        /// First name of the employee
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Last name of the employee
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Role of the employee
        /// </summary>
        public string Role { get; set; }
        /// <summary>
        /// Date when the employee was hired
        /// </summary>
        public DateTime DateHired { get; set; }
        /// <summary>
        /// Date when the employee has been deleted, aka hiden, from the system
        /// </summary>
        public DateTime DateDeleted { get; set; }
    }
}
