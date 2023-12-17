namespace DesignPatterns_Learning.FactoryMethod.Transportation
{
    internal class RoadTransport : ITransport
    {
        public string Deliver()
        {
            return "Delivered by road";
        }
    }
}
