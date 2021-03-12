using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBigData
{
    public class Livre
    {
         [BsonId]
        public Guid Id;
        public string titre { get; set; }
        public double prix { get; set; }
        public int numero { get; set; }
    }
}
