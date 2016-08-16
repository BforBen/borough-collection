namespace GuildfordBoroughCouncil.BoroughCollection.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BoroughCollectionMovement")]
    public partial class BoroughCollectionMovement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MovementID { get; set; }

        public int? WorksID { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        [StringLength(50)]
        public string MovedBy { get; set; }

        public DateTime? DateMoved { get; set; }

        [StringLength(50)]
        public string Reason { get; set; }

        [StringLength(20)]
        public string FormNumber { get; set; }

        [StringLength(100)]
        public string LoanName { get; set; }

        [StringLength(200)]
        public string LoanAddress { get; set; }

        [StringLength(20)]
        public string LoanTelephone { get; set; }

        [StringLength(20)]
        public string LoanFax { get; set; }

        [StringLength(100)]
        public string LoanEmail { get; set; }

        [StringLength(500)]
        public string Terms { get; set; }
    }
}
