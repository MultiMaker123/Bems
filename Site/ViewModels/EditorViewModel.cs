using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Site.DB;

namespace Site.ViewModels
{
    public class EditorViewModel
    {
        public string viewContext;
        public IQueryable<Report> Papers { get; set; }
    }
}