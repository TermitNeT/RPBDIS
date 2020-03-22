using Microsoft.AspNetCore.Mvc.Rendering;
using CourseWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWork.ViewModels
{
    public class FilterViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Material> Materials { get; set; }
        public IEnumerable<Team> Teams { get; set; }
        public IEnumerable<TypeOfWork> TypeOfWorks { get; set; }
        public IEnumerable<Worker> Workers { get; set; }  
        public IEnumerable<Position> Positions { get; set; }  
        
        public string Name { get; set; }

        public string Position { get; set; }
        public string Surname { get; set; }
        public string NumOfMaterias { get; set; }


        public FilterViewModel(string name)
        {
            NumOfMaterias = name;
        }

        public FilterViewModel(string position, string surname, string name)
        {
            Surname = surname;
            Position = position;
            Name = name;
        }

        public FilterViewModel(string surname, string name)
        {
            Surname = surname;
            Name = name;
        }
    }
}
