using FactoryDI.Car;

namespace FactoryDI.Factory
{
    public class SportyCarFactory : ICarFactory
    {
        public CarType CarType { get; } = CarType.Sporty;

        public ICar Create()
        {
            return new SportyCar();
        }
    }
}