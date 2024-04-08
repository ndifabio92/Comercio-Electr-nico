using Mango.Services.EmailAPI.Models.Base;

namespace Mango.Services.EmailAPI.Entities
{
    public class EmailLogger: EntityBase
    {
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime? EmailSent { get; set; }
    }
}
