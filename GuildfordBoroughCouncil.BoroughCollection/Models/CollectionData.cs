namespace GuildfordBoroughCouncil.BoroughCollection.Models
{
    using System.Data.Entity;

    public partial class CollectionData : DbContext
    {
        public CollectionData()
            : base("name=CollectionData")
        {
        }

        public virtual DbSet<BoroughCollectionArtist> BoroughCollectionArtists { get; set; }
        public virtual DbSet<BoroughCollectionLocation> BoroughCollectionLocations { get; set; }
        public virtual DbSet<BoroughCollectionMovement> BoroughCollectionMovements { get; set; }
        public virtual DbSet<BoroughCollectionWork> BoroughCollectionWorks { get; set; }
    }
}
