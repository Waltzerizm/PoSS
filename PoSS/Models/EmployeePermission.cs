namespace PoSS.Models
{
    public class EmployeePermission
    {
        /// <summary>
        /// Permission ID
        /// </summary>
        public int PermissionId { get; set; }
        /// <summary>
        /// Employee ID to who the permission is granted to
        /// </summary>
        public int EmployeeId { get; set; }
    }
}
