using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pierogarnia.Models
{
    public class Contact
    {
        public Contact()
        {
            Issues = new HashSet<Issue>();
        }

        [HiddenInput]
        public int Id { get; set; }

        
        public string Name { get; set; }
        public int Category { get; set; }        
        [Required(ErrorMessage = "Wybierz rodzaj pierogów")]
        [Range(1, 100, ErrorMessage = "Musisz wybrac ilość pierogów, co najmniej 1, nie większą niż 100")]
        public int Quantity { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Musisz podać adres dostawy")]
        [MaxLength(15, ErrorMessage = "Nazwa nie może być dłuższa niż 15 znaków")]
        public string Address { get; set; }

        [RegularExpression(".+\\@.+\\.[a-z]{2,3}", ErrorMessage = "Niepoprawny adres email!")]
        public string Email { get; set; }
        [Phone(ErrorMessage ="Numer musi zawierać tylko cyfry!")]
        public string Phone { get; set; }

        [DisplayFormat(DataFormatString ="{0:F2}")]
        public int Rating { get; set; }

        public ICollection<Issue> Issues { get; set; }
    }
}
