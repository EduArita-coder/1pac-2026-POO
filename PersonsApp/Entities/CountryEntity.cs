using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PersonsApp.Entities
{
    [Table("countries")]
    public class CountryEntity : BaseEntity
    {
        [Column("Name")]
        [Required()]
        public string Name { get; set; }

        [Column("Alpha_Code_3")]
        [Required()]
        public string AlphaCode3 { get; set; }

        public virtual IEnumerable<PersonEntity> Persons { get; set; }
    }
}