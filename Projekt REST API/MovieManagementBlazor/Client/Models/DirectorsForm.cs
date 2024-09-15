using System;
using System.ComponentModel.DataAnnotations;

namespace MovieManagementBlazor.Client.Models
{
    public class DirectorsForm
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DoB { get; set; }
        [Required]
        public string PlaceOfBirth { get; set; }
    }
}
