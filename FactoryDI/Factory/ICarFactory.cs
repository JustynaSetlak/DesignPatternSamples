using FactoryDI.Car;

namespace FactoryDI.Factory
{
    public interface ICarFactory
    {
        CarType CarType { get; }
        ICar Create();
    }
}