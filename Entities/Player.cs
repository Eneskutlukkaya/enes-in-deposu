using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
         class Player
    {
        public int PlayerId { get; set; }
        public string NationalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}
