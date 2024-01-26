namespace Core.Persistence.Repositories
{
    public class Entity<TId> : IEntityTimeStamps
    {

        public object Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public Entity()
        {
            Id = default!;
        }

        public Entity(object id) : this()
        {
            Id = id;
        }
    }
}
