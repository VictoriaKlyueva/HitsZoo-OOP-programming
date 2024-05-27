using System;

namespace HitsZoo
{
    public interface IEntity
    {
        int Id { get; set;  }
        Guid Id2 { get; }

        string Print();
        void Update(IEntity entity);
    }
}
