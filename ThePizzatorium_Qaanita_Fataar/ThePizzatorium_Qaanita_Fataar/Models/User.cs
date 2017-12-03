using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ThePizzatorium_Qaanita_Fataar.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Address Address { get; set; }
        public Pizza FavPizza { get; set; }
        public bool IsAdmin { get; set; } = false;

        public void Update(User NewValues)
        {
            this.Name = NewValues.Name;
            this.Surname = NewValues.Surname;
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
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Zipcode { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
    }
}