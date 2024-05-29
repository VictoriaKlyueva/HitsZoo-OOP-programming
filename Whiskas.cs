namespace HitsZoo
{
    public class Whiskas : FoodMark
    {
        public override int CriticalWeight { get; set; }

        public Whiskas() 
        {
            CriticalWeight = 10;
        }
    }
}
