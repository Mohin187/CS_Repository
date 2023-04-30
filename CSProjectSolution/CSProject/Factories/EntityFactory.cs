using CSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject.Factories
{
    public class EntityFactory : IEntityFactory
    {
        public T Create<T>(params object[] args) where T : Entity
        {
            return Activator.CreateInstance(typeof(T), args) as T;
        }
        
    }
}
