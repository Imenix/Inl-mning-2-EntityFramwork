using System.ComponentModel.DataAnnotations;

namespace Inlämning_2_EntityFramwork.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Birthyear { get; set; }
        public string? DeathYear { get; set; }
        public string? Father { get; set; }
        public string? Mother { get; set; }
    }
}