using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject.Models
{
    public class Batch:Entity
    {
        public Batch() { }
        public Batch(int id, string batchCode)
        {
            this.Id = id;

            this.BatchCode = batchCode;

        }
        

        public string BatchCode { get; set; }

        public override string ToString()
        {
            return $"Id: {Id} Batch Code:{BatchCode}";
        }
    }
}
