using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseWork.Models
{
    public partial class TypeOfWork
    {
        public TypeOfWork()
        {
            ListMaterials = new HashSet<ListMaterial>();
            Orders = new HashSet<Order>();
        }


        [Required]
        public int TypeOfWorkId { get; set; }

        //[Required]
        //[RegularExpression(@"[А-Яа-яA-Za-z]{3,20}", ErrorMessage = "В названии материала присутствуют некорректные символы")]
        //[StringLength(20, MinimumLength = 3, ErrorMessage = "Название должно быть от 3 до 20 символов")]
        public string WorkName { get; set; }

        //[Required]
        //[RegularExpression(@"[А-Яа-яA-Za-z]{3,20}", ErrorMessage = "В названии материала присутствуют некорректные символы")]
        //[StringLength(20, MinimumLength = 3, ErrorMessage = "Название должно быть от 3 до 20 символов")]
        public string Description { get; set; }


        [Required]
        [Range(0, 10000000, ErrorMessage = "Недопустимый диапазон")]
        public decimal Price { get; set; }


        public virtual ICollection<ListMaterial> ListMaterials { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
