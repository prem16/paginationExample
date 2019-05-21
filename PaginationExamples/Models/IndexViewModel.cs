using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaginationExamples.Models
{
    public class IndexViewModel
    {
        public IEnumerable<string> Items { get; set; }
        public Pager Pager { get; set; }
    }
}