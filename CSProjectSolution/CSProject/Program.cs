using CSProject.Factories;
using CSProject.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEntityFactory entityFactory = new EntityFactory();
            FactoryTest obj = new FactoryTest(entityFactory);
            obj.Test();
            Console.ReadLine();
        }
    }
}
