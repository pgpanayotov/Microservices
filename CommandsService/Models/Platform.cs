using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CommandsService.Models
{
    public class Platform
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required] 
        public int ExternalId { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Command> Commands { get; set; } = new List<Command>();
    }
}