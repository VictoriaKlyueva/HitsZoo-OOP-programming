using System;

namespace HitsZoo
{
    public interface IEntity
    {
        Guid Id { get; }

        string Print();

        void Update(IEntity entity);

        int CompareTo(IEntity other);
    }
}
