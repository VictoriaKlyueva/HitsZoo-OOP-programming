namespace HitsZoo
{
    abstract public class FoodMark
    {
        public virtual int CriticalWeight { get; set; }
        private int food = 0;

        public void AddFood(int food)
        {
            this.food = this.food + food < CriticalWeight ? this.food + food : CriticalWeight;
        }

        public void RemoveFood(int food)
        {
            this.food = this.food - food > 0 ? this.food - food : 0;
        }

        public bool IsEmpty()
        {
            return food == 0;
        }

        public int Print()
        {
            return this.food;
        }
    }
}
