using FactoryDI.Car;

namespace FactoryDI.Factory
{
    public class SportyCarFactory : ICarFactory
    {
        public CarType CarType => CarType.Sporty;

        public ICar Create()
        {
            return new SportyCar();
        }
    }
}
