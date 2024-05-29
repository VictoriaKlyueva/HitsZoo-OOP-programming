
namespace HitsZoo
{
    public interface IFeeding
    {
        int Food { get; set; }

        void UpdateFood(int food);

        void Feed();

        bool IsFoodEmpty();
    }
}
