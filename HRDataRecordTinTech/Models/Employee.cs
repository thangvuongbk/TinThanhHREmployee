using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace HRDataRecordTinTech.Models
{
    public class Employee
    {      
        [Key]
        [Required(ErrorMessage = "Employee ID is required")]
        [Range(10000, 99999, ErrorMessage = "Employee Id should be of 5 digits.")]
        [Remote("CheckIfIdExists", "Employee", ErrorMessage = "Employee Id already exists")]
        public int EmployeeId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(30)]
        [RegularExpression("^[A-Za-z ]+$", ErrorMessage = "Name cannot contain numbers or special characters.")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Phone is required")]
        [Range(0000000000, 9999999999, ErrorMessage = "Phone no. is not valid")]
        public Nullable<long> Phone { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [StringLength(30)]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail address is not valid")]
        [DisplayName("Email Address")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Position is required")]
        [StringLength(40)]
        [RegularExpression("^[A-Za-z ]+$", ErrorMessage = "Position cannot contain numbers or special characters.")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Salary is required")]
        [Range(0, 99999999999, ErrorMessage = "Salary is not within range.")]
        public Nullable<long> Salary { get; set; }
    }


}
