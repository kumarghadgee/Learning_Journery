using System.ComponentModel.DataAnnotations;

namespace _01_WebAPI.Models
{
    public partial class Emp
    {
        public int No { get; set; }

        [Required(ErrorMessage = "Name is Required.")]
        [DuplicateCheck(ErrorMessage = "Name already exists.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is Required")]
        public string Address { get; set; }
    }

    public class DuplicateCheck : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value != null)
            {
                KaradDbContext db = new KaradDbContext();

                var empFromDB = db.Emps.Where(e => e.Name.ToLower() == value.ToString().ToLower()).FirstOrDefault();

                if(empFromDB != null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
