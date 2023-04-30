using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProject.Models
{
    public class Trainee:Entity
    {
        public Trainee() { }
        public Trainee(int id, string name, int batchId, bool isContinuing)
        {
            Id = id;
            Name = name;
            this.BatchId = batchId;
            this.IsContinuing = isContinuing;
        }

       
        public string Name { get; set; }
        public int BatchId { get; set; }
        public bool IsContinuing { get; set; }
        public override string ToString()
        {
            return $"Id: {Id} Name: {Name} Batch Id: {BatchId} Continuing: {(IsContinuing ? "Yes" : "No")}";
        }
    }
}

