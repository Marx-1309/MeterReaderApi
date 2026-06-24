using System.ComponentModel.DataAnnotations;

namespace MeterReaderApi.Models
{
    public class AspNetUserSites
    {
        [Key]
        public string UserId { get; set; }

        public string Site { get; set; }
    }
}