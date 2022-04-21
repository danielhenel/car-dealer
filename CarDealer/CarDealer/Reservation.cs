using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    public class Reservation
    {
        String name;
        DateTime date;
        public Reservation(String name, DateTime date)
        {
            this.name = name;
            this.date = date;
        }

        public string Name { get => name; set => name = value; }
        public DateTime Date { get => date; set => date = value; }

        public String ToString()
        {
            return "NAME: " +  name + " " + "DATE: " + date.ToString();
        }

    }
}
