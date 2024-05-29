namespace HitsZoo
{
    public class Pedigree : FoodMark
    {
        public override int CriticalWeight { get; set; }

        Pedigree()
        {
            CriticalWeight = 20;
        }
    }
}
