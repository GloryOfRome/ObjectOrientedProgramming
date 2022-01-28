using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Room
    {
        public string Number;
        public int Capacity;
        public bool Occupied;

        public List<Reservation> Reservations;
    }
}
