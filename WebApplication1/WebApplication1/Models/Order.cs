using System;
using System.ComponentModel.DataAnnotations;

namespace CourseWork.Models
{
    public partial class Order
    {

        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        public int TeamId { get; set; }

        public int TypeOfWorkId { get; set; }

        [Range(0, 10000000, ErrorMessage = "Недопустимый диапазон")]
        public decimal Price { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime FinishDate { get; set; }

        public bool ComplectionStatus { get; set; }

        public bool PayStatus { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Team Team { get; set; }

        public virtual TypeOfWork TypeOfWork { get; set; }
    }
}
