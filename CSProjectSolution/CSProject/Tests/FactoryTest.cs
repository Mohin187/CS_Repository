using CSProject.Factories;
using CSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject.Tests
{
    public class FactoryTest
    {
        private readonly IEntityFactory ef;
        public FactoryTest(IEntityFactory ef)
        {
            this.ef = ef;
        }
        public void Test()
        {
            var batches = new[]
            {
                ef.Create< Batch>(1, "CS/ACSL-M/52/01"),
                ef.Create<Batch>(2, "GAVE/ACSL-M/53/01"),
                ef.Create<Batch>(3, "CCO/ACSL-M/51/01"),
                ef.Create<Batch>(4, "CS/ACSL-M/54/01")
            };
            batches.ToList()
                .ForEach(b => Console.WriteLine(b));
            Console.WriteLine();
            var trainees = new[]
            {
                ef.Create< Trainee>(101, "Zahirul Islam", 1, true),
                ef.Create<Trainee>(102, "Jahangir ALama", 2, true),
                ef.Create<Trainee>(103, "Mustakim Naim", 3, true),
                ef.Create<Trainee>(104, "Noushin Lima", 3, true),
                ef.Create<Trainee>(105, "Umme Kulsum", 3, true)
            };
            trainees
                .ToList()
                .ForEach(t => Console.WriteLine(t));
        }
    }
}
