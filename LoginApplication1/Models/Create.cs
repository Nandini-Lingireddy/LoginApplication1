using System.ComponentModel.DataAnnotations;

namespace LoginApplication1.Models
{
    public class Create
    {
        [Key]
        public int ID { get; set; }
        public string username { get; set; }

        [DataType(DataType.Password)]
        public string password { get; set; }

    }
}
