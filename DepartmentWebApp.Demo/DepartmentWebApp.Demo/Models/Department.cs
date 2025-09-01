using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentWebApp.Demo.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int DepId { get; set; }
        public string DepName { get; set; }
        public string HOD { get; set; }
    }
}
