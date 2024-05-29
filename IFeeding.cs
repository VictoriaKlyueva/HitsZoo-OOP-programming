
namespace HitsZoo
{
    public interface IFeeding
    {
        FoodMark Food { get; set; }

        void UpdateFood<Mark>(int food) where Mark : FoodMark, new();

        void Feed();

        bool IsFoodEmpty();
    }
}
