using System;
using System.Collections.Generic;
using System.Linq;
using FactoryDI.Factory;

namespace FactoryDI.Services
{
    public class CarService
    {
        private readonly IEnumerable<ICarFactory> _factories;

        public CarService(IEnumerable<ICarFactory> factories)
        {
            _factories = factories;
        }

        public ICarFactory CreateCar(CarType type)
        {
            var factory = _factories.FirstOrDefault(x => x.CarType == type);

            return factory ?? throw new InvalidOperationException();
        }
    }
}