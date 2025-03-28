using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Person
    {
        [Key]
        public string? PersonId { get; set;}
        public string FullName { get; set;}=string.Empty;
        public string Address { get; set;}= string.Empty;
    }
}


