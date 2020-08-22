using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Activity3.Models
{
    public class CustomerModel : IComparable
    {
        public int ID { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Age")]
        public int Age { get; set; }

        public CustomerModel(string name, int age)
        {
            
            this.Name = name;
            this.Age = age;

        }

        public int CompareTo(object obj)
        {
            CustomerModel cus = obj as CustomerModel;

            return Name.CompareTo(cus.Name);
        }
    }
}