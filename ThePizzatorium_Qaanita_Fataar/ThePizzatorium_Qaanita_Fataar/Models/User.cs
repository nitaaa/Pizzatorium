using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ThePizzatorium_Qaanita_Fataar.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }


        [Required(ErrorMessage = "Name required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Username required")]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Email required")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [ForeignKey("Address")]
        public Address AddressID { get; set; }

        [ForeignKey("Pizza")]
        public Pizza FavPizzaID { get; set; }


        public bool IsAdmin { get; set; } = false;

        public void Update(User NewValues)
        {
            this.Name = NewValues.Name;
            this.Username = NewValues.Username;
            this.Email = NewValues.Email;
            this.Password = NewValues.Password;
            this.IsAdmin = NewValues.IsAdmin;
        }
    }

    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string StreetAddress { get; set; }
        public string Suburb { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
    }
}