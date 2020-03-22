using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseWork.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
        [Required]
        public int CustomerId { get; set; }

        [Required]
        [RegularExpression(@"[А-Яа-яA-Za-z]{3,20}", ErrorMessage = "В фамилии присутствуют некорректные символы")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Фамилия должна быть от 3 до 20 символов")]
        public string Surname { get; set; }

        [Required]
        [RegularExpression(@"[А-Яа-яA-Za-z]{3,20}", ErrorMessage = "В имени присутствуют некорректные символы")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Имя должно быть от 3 до 20 символов")]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"[А-Яа-яA-Za-z]{3,20}", ErrorMessage = "В имени присутствуют некорректные символы")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Имя должно быть от 3 до 20 символов")]
        public string MiddleName { get; set; }


        [Required]
        [RegularExpression(@"[А-Яа-яA-Za-z0-9.,\s]{7,30}", ErrorMessage = "В адресе присутствуют некорректные символы")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Фамилия должна быть от 3 до 20 символов")]
        public string Adress { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 7, ErrorMessage = "Недопустимый номер")]
        public string Phone { get; set; }

        [Required]
        [RegularExpression(@"[A-ZА-ЯФ-Яa-z]{2}[0-9]{7}", ErrorMessage = "Неверное значение")]
        public string Passport { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
