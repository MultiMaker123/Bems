using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Site.DB;

namespace Site.Abstract
{
    // interface for database objects
    public interface IBemsRepository
    {
        IQueryable<Bill> Bills { get; set; }
        void DeleteBills(int[] Ids);
        void SaveBill(Bill bill);
        void CreateBill();
        IQueryable<Report> Reports { get; set; }
        void DeleteReports(int Ids);
        void SaveReport(Report report);
        void CreateReport();
        IQueryable<Ticket> Tickets { get; set; }
        void DeleteTickets(int[] Ids);
        void SaveTicket(Ticket ticket);
        void CreateTicket();
    }
}
