using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SpendMe.Core
{
    public class SystemRecords
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
