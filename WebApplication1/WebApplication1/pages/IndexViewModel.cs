using CourseWork.Models;
using CourseWork.ViewModels;
//using CourseWork.ViewModels.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.pages
{
    public class IndexViewModel
    {
        public FilterViewModel FilterViewModel { get; set; }

        public IEnumerable<Customer> customers { get; set; }
        public IEnumerable<ListMaterial> listMaterials { get; set; }
        public IEnumerable<Material> materials { get; set; }
        public IEnumerable<Order> orders { get; set; }
        public IEnumerable<Team> teams { get; set; }
        public IEnumerable<TypeOfWork> TypeOfWorks { get; set; }
        public IEnumerable<Worker> workers { get; set; }

        //public Filter Filter { get; set; }

        public List<string> List { get; set; }
        public List<string> ListNum { get; set; }
        public PageViewModel PageViewModel { get; set; }

        public Team team { get; set; }
        public string teamInfo { get; set; }

        public string NumOfMaterials { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

    }
}
