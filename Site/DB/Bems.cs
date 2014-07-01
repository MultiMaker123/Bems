using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Site.DB
{
    public class Bems
    {
    }

    public class Paper
    {
        private int ID;
        private string name;

        public string Name { get { return name; } }
    }

    public class Report : Paper
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }

    public class Bill : Paper
    {
        private int billID;

        public int ID { get { return billID; } set { billID = ID; } }
        public string Name { get; set; }
        public double Amount { get; set; }
    }

    public class Ticket : Paper
    {
        private int ticketID;

        public int ID { get { return ticketID; } set { ticketID = ID; } }
        public string Name { get; set; }
        public double Amount { get; set; }
    }
}