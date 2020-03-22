using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseWork.Models
{
    public partial class Worker
    {

        [Required]
        public int WorkerId { get; set; }


        [Required]
        [RegularExpression(@"[А-Яа-яA-Za-z]{3,20}", ErrorMessage = "В фамилии присутствуют некорректные символы")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Фамилия должна быть от 3 до 20 символов")]
        public string Surname { get; set; }


        [Required]
        [RegularExpression(@"[А-Яа-яA-Za-z]{3,20}", ErrorMessage = "В фамилии присутствуют некорректные символы")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Фамилия должна быть от 3 до 20 символов")]
        public string Name { get; set; }


        [Required]
        [RegularExpression(@"[А-Яа-яA-Za-z]{3,20}", ErrorMessage = "В фамилии присутствуют некорректные символы")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Фамилия должна быть от 3 до 20 символов")]
        public string MiddleName { get; set; }


        [Required]
        [Range(14, 100, ErrorMessage = "Недопустимый диапазон")]
        public int Age { get; set; }

        [Required]
        [RegularExpression(@"[ж,м]{1}", ErrorMessage = "В фамилии присутствуют некорректные символы")]
        public string Sex { get; set; }

        [Required]
        [RegularExpression(@"[А-Яа-яA-Za-z0-9.,\s]{7,30}", ErrorMessage = "В адресе присутствуют некорректные символы")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Фамилия должна быть от 3 до 20 символов")]
        public string Adress { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 7, ErrorMessage = "Недопустимый номер")]
        public string Phone { get; set; }


        [Required]
        [RegularExpression(@"[A-ZА-Яа-я]{2}[0-9]{7}", ErrorMessage = "Неверное значение")]
        public string Passport { get; set; }

        [Required]
        public int PositionId { get; set; }

        [Required]
        public int TeamId { get; set; }



        public virtual Position Position { get; set; }

        public virtual Team Team { get; set; }
    }
}
