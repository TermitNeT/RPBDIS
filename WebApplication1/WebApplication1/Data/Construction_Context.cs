using Microsoft.EntityFrameworkCore;
using CourseWork.Models;

namespace CourseWork.Data
{
    public partial class Construction_Context : DbContext
    {
        public Construction_Context(DbContextOptions<Construction_Context> options) 
            : base(options)
        {

        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ListMaterial> ListMaterials { get; set; }
        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TypeOfWork> TypeOfWorks { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
    }
}
