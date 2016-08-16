namespace GuildfordBoroughCouncil.BoroughCollection.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BoroughCollectionArtist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ArtistID { get; set; }

        [StringLength(100)]
        public string ArtistName { get; set; }

        public string Description { get; set; }

        public virtual ICollection<BoroughCollectionWork> Works { get; set; }
    }
}
