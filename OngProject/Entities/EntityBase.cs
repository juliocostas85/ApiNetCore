using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Entities
{
    public class EntityBase
    {

        public int Id { get; set; }

        [Required]
        public DateTime DateModified { get; set; } = DateTime.Now;

        [Required]
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
