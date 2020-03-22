using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseWork.Models
{
    public partial class Team
    {
        public Team()
        {
            Orders = new HashSet<Order>();
            Workers = new HashSet<Worker>();
        }

        [Required]
        public int TeamId { get; set; }

        [Required]
        [RegularExpression(@"[А-Яа-яA-Za-z\s0-9]{3,20}", ErrorMessage = "В названии материала присутствуют некорректные символы")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Название должно быть от 3 до 20 символов")]
        public string TeamName { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Worker> Workers { get; set; }
    }
}
