using System.ComponentModel.DataAnnotations;

namespace Mango.Services.EmailAPI.Models.Base
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime? Updated { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
