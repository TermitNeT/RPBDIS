using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseWork.Models
{
    public partial class Position
    {
        public Position()
        {
            Workers = new HashSet<Worker>();
        }

        [Required]
        public int PositionId { get; set; }

        [Required]
        [RegularExpression(@"[А-Яа-яA-Za-z]{3,20}", ErrorMessage = "В названии материала присутствуют некорректные символы")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Название должно быть от 3 до 20 символов")]
        public string PositionName { get; set; }

        public virtual ICollection<Worker> Workers { get; set; }
    }
}
