
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Domain.Entity
{
        public class ApplicationType
        {
            [Key]
            public int Id { get; set; }
            public string Name { get; set; }

        }
    
}
