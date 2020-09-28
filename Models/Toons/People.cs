using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace lab_2.Models.Toons
{
    public partial class People
    {
        public int Id { get; set; }
        [Display (Name ="Last Name")]
        public string LastName { get; set; }
        
        [Display (Name ="First Name")]
        public string FirstName { get; set; }
        
        public string Occupation { get; set; }
        
        public string Gender { get; set; }
        
        [Display (Name ="Picture")]
        public string PictureUrl { get; set; }
      
        public int Votes { get; set; }
    }
}
