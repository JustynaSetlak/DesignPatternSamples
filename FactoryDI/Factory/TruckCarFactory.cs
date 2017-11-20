using FactoryDI.Car;

namespace FactoryDI.Factory
{
    public class TruckCarFactory : ICarFactory
    {
        public CarType CarType => CarType.Truck;

        public ICar Create()
        {
            return new TruckCar();
        }
    }
}
