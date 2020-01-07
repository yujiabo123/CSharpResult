namespace Y_DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountInfo")]
    public partial class AccountInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountId { get; set; }

        [Required]
        [StringLength(50)]
        public string Account { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string MachineId { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(15)]
        public string QQ { get; set; }

        [StringLength(50)]
        public string WeChat { get; set; }

        [StringLength(50)]
        public string WeiBo { get; set; }
    }
}
