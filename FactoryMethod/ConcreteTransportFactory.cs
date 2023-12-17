using DesignPatterns_Learning.FactoryMethod.Transportation;

namespace DesignPatterns_Learning.FactoryMethod
{
    internal class ConcreteTransportFactory : Factory
    {
        public override ITransport ProduceRoadTransport()
        {
            return new RoadTransport();
        }

        public override ITransport ProduceSeaTransport()
        {
            return new SeaTransport();
        }
    }
}
