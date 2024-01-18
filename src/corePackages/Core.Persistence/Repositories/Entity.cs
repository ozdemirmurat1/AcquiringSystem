﻿namespace Core.Persistence.Repositories
{
    public class Entity<TId> : IEntityTimeStamps
    {

        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        public Entity()
        {
            Id = default!;
        }

        public Entity(int id) : this()
        {
            Id = id;
        }
    }
}
