namespace Y_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VertifyRecord")]
    public partial class VertifyRecord
    {
        public int Id { get; set; }

        public int AccountId { get; set; }

        [Required]
        [StringLength(50)]
        public string VertifyCode { get; set; }

        public long InvalidTime { get; set; }

        public long SendTime { get; set; }

        public short Nullity { get; set; }
    }
}
