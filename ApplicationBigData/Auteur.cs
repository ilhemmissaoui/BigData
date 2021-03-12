using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBigData
{
   public class Auteur
    {
        [BsonId]
        public Guid idAuteur;
        public string nom { get; set; }
        public string prenom { get; set; }
        public string domicile { get; set; }
        public int numero { get; set; }
    }
}
