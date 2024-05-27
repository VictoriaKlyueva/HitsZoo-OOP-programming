
namespace HitsZoo
{
    public interface IFood
    {
        int Food { get; set; }

        void UpdateFood(int food);

        void Feed();

        bool IsFoodEmpty();
    }
}
