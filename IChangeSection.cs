namespace HitsZoo
{
    public interface IChangeSection
    {
        void ChangeSection(
                Animal animal, 
                IOpenSection openEnclouser, 
                IClosedSection closedEnclouser
            );
    }
}
