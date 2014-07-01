using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Site.Abstract;
using Site.DB;

namespace Site.Concrete
{
    public class EFBemsRepo : IBemsRepository
    {
        private EFBemsContext context = new EFBemsContext();

        public IQueryable<Ticket> Tickets
        {
            get { return context.Tickets; }
            set {
                foreach(Ticket ticket in value)
                {
                    if (!context.Tickets.Contains(ticket))
                    {
                        context.Tickets.Add(ticket);
                    }
                }
                context.SaveChanges();
            }
        }

        public void DeleteTickets(int[] Ids)
        {
            Ticket deletedTicket = context.Tickets.Find(Ids);
            context.Tickets.Remove(deletedTicket);
            context.SaveChanges();
        }

        public void SaveTicket(Ticket ticket)
        {
            Ticket savedTicket = context.Tickets.Find(ticket.ID);
            savedTicket.Name = ticket.Name;
            savedTicket.Amount = ticket.Amount;
            context.SaveChanges();
        }

        public void CreateTicket()
        {
            Ticket createdTicket = context.Tickets.Create();
            context.SaveChanges();
        }

        public IQueryable<Bill> Bills
        {
            get { return context.Bills; }
            set
            {
                foreach (Bill bill in value)
                {
                    if (!context.Bills.Contains(bill))
                    {
                        context.Bills.Add(bill);
                    }
                }
                context.SaveChanges();
            }
        }

        public void DeleteBills(int[] Ids)
        {
            Bill deletedBill = context.Bills.Find(Ids);
            context.Bills.Remove(deletedBill);
            context.SaveChanges();
        }

        public void SaveBill(Bill bill)
        {
            Bill savedBill = context.Bills.Find(bill.ID);
            savedBill.Name = bill.Name;
            savedBill.Amount = bill.Amount;
            context.SaveChanges();
        }

        public void CreateBill()
        {
            Bill createdBill = context.Bills.Create();
            context.SaveChanges();
        }

        public IQueryable<Report> Reports
        {
            get { return context.Reports; }
            set
            {
                foreach (Report report in value)
                {
                    if (!context.Reports.Contains(report))
                    {
                        context.Reports.Add(report);
                    }
                }
                context.SaveChanges();
            }
        }

        public void DeleteReports(int Ids)
        {
            Report deletedReports = context.Reports.Find(Ids);
            context.Reports.Remove(deletedReports);
            context.SaveChanges();
        }

        public void SaveReport(Report report)
        {
            Report savedReport = context.Reports.Find(report.ID);
            savedReport.Name = report.Name;
            savedReport.Amount = report.Amount;
            context.SaveChanges();
        }

        public void CreateReport()
        {
            Report createdReport = new Report();
            createdReport.Name = "Default";
            createdReport.Amount = 0;
            context.Reports.Add(createdReport);
            context.SaveChanges();
        }
    }
}