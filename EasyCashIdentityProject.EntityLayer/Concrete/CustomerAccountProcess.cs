using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccountProcess
    {
        public int CustomerAccountProcessID { get; set; }
        public string CustomerAccountProcessType { get;set; }
        public decimal CustomerAccountProcessAmount { get;set; }
        public DateTime CustomerAccountProcessDate{ get;set; }

        public int? SenderID { get; set; }
        public int? ReceverID { get; set; }
        public CustomerAccount SenderCustomer { get; set; }
        public CustomerAccount RecevierCustomer { get; set; }
    }
}
