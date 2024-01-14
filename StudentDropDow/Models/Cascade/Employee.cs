using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentDropDow.Models.Cascade
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Empname")]
        [StringLength(100)]
        public string EmpName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public string MoileNo { get; set; }

        [Required(ErrorMessage = "Please enter Address")]
        [StringLength(100)]
        public string Address { get; set; }
      

        [Required(ErrorMessage = "Please enter LastName")]
        [StringLength(100)]
        public string LastName { get; set; }

        public string Image { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string CityName { get; set; }
    }
}
