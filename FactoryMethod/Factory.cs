using DesignPatterns_Learning.FactoryMethod.Transportation;

namespace DesignPatterns_Learning.FactoryMethod
{
    internal abstract class Factory
    {
        public abstract ITransport ProduceRoadTransport();
        public abstract ITransport ProduceSeaTransport();
    }
}
