namespace HitsZoo
{
    public class Whiskas : FoodMark
    {
        public override int CriticalWeight { get; set; }

        Whiskas() 
        {
            CriticalWeight = 10;
        }
    }
}
