namespace ef.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patientdetail")]
    public partial class Patientdetail
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public int? Age { get; set; }

        [StringLength(10)]
        public string Contact { get; set; }
    }
}
