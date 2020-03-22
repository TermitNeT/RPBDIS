using System.ComponentModel.DataAnnotations;

namespace CourseWork.Models
{
    public partial class ListMaterial
    {
        [Key]
        public int ListId { get; set; }
        public int MaterialId { get; set; }
        public int TypeOfWorkId { get; set; }

        public virtual Material Material { get; set; }
        public virtual TypeOfWork TypeOfWork { get; set; }
    }
}
