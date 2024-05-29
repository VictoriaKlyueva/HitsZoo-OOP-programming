namespace HitsZoo
{
    public class Pedigree : FoodMark
    {
        public override int CriticalWeight { get; set; }

        public Pedigree()
        {
            CriticalWeight = 20;
        }
    }
}
