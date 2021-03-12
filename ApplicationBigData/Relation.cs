using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBigData
{
   public  class Relation
    {
        [BsonId]
        public Guid idRelation;
        public string titre { get; set; }
        public string nom { get; set; }
    }
}
