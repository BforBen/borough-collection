namespace GuildfordBoroughCouncil.BoroughCollection.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BoroughCollectionWork
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WorkID { get; set; }

        public int? Artist { get; set; }

        [StringLength(200)]
        public string WorkTitle { get; set; }

        [StringLength(100)]
        public string Media { get; set; }

        [StringLength(50)]
        public string Period { get; set; }

        [StringLength(50)]
        public string Subject { get; set; }

        [StringLength(50)]
        public string WorkSize { get; set; }

        [StringLength(2000)]
        public string Description { get; set; }

        [StringLength(200)]
        public string ImageName { get; set; }

        [StringLength(10)]
        public string ImageSize { get; set; }

        public bool Publish { get; set; }

        [StringLength(10)]
        public string AccessionNumber { get; set; }

        public bool Framed { get; set; }

        [StringLength(20)]
        public string Dated { get; set; }

        [StringLength(100)]
        public string CopyrightOwner { get; set; }

        [StringLength(200)]
        public string CopyrightAddress { get; set; }

        [StringLength(20)]
        public string CopyrightTelephone { get; set; }

        [StringLength(100)]
        public string CopyrightEmail { get; set; }

        [StringLength(50)]
        public string HomeLocation { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool GrantAid { get; set; }

        [StringLength(2000)]
        public string OtherInformation { get; set; }

        [StringLength(100)]
        public string ReceivedFrom { get; set; }

        [StringLength(50)]
        public string ReceivedFromName { get; set; }

        [StringLength(200)]
        public string ReceivedFromAddress { get; set; }

        [StringLength(200)]
        public string ReceivedFromTelephone { get; set; }

        [StringLength(100)]
        public string ReceivedFromEmail { get; set; }

        [Column(TypeName = "smallmoney")]
        public decimal? Cost { get; set; }

        public DateTime? GalleryEntry { get; set; }

        public DateTime? GalleryExit { get; set; }

        public DateTime? DateAccessioned { get; set; }

        public bool TitleTransfered { get; set; }

        [ForeignKey("Artist")]
        public virtual BoroughCollectionArtist ArtistDetails { get; set; }
    }
}
