namespace HitsZoo
{
    public interface IChangeSection
    {
        void ChangeSection(
                Animal animal, 
                IOpenSection<Animal> openEnclouser, 
                IClosedSection<Animal> closedEnclouser
            );
    }
}
