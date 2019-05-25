using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curfew
{
    internal class Face
    {
        public byte[] Image { get; set; } // training faces

        public int Id { get; set; } // auto increment id

        public String Label { get; set; } // name

        public int UserId { get; set; } // student id
    }
}
