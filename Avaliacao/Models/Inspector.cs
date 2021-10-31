using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao.Models
{
    public class Inspector
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Inspector(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
