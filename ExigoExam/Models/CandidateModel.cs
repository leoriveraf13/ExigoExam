using System;
using System.ComponentModel.DataAnnotations;

namespace ExigoExam.Models
{
    public enum Positions
    {
        Web, DBA, Bussiness_Analyst
    }
    
    public class CandidateModel
    {
        private bool positionValidate(object value)
        {
            return Enum.IsDefined(typeof(Positions), value);
        }

        [Required(ErrorMessage = "The field First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The field Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The field Position is required")]
        public Positions Position { get; set; }

        [Required(ErrorMessage = "The field Joining Date is required")]
        public DateTime JoiningDate { get; set; }

        [Required(ErrorMessage = "The field Salary is required")]
        [Range(1, int.MaxValue, ErrorMessage = "The field Salary must be greater than 0.")]
        public int Salary { get; set; }
        public bool OtherAplies { get; set; }
    }
}