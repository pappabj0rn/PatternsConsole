using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatternsConsole.Creational.AbstractFactory
{
    public interface IFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }
}
