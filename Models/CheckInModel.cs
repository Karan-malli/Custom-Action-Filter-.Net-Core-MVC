using System.ComponentModel.DataAnnotations;

namespace CustomActionFilter.Models
{
    public class CheckInModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime InTime { get; set; }
    }
}
