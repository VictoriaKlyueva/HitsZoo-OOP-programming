namespace HitsZoo
{
    internal interface IChangeSection
    {
        void ChangeSection(
            Animal animal, 
            IOpenEnclouser openEnclouser, 
            IClosedEnclouser closedEnclouser
            );
    }
}
