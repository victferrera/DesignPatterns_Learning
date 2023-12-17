namespace DesignPatterns_Learning.FactoryMethod.Transportation
{
    internal class SeaTransport : ITransport
    {
        public string Deliver()
        {
            return "Delivered by sea";
        }
    }
}
