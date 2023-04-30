using CSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject.Factories
{
    public interface IEntityFactory
    {

        T Create<T>(params object[] args) where T :  Entity;
    }
}
