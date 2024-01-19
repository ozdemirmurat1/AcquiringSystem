namespace Core.Persistence.Repositories
{
    public class Entity<TId> : IEntityTimeStamps
    {

        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public Entity()
        {
            Id = default!;
        }

        public Entity(Guid id) : this()
        {
            Id = id;
        }
    }
}
