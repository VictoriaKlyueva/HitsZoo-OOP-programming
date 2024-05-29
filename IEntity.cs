using System;

namespace HitsZoo
{
    public interface IEntity
    {
        Guid Id2 { get; }

        string Print();
        void Update(IEntity entity);
    }
}
