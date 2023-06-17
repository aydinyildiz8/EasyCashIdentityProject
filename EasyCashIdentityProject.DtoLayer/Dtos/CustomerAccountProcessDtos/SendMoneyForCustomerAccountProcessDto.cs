using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.DtoLayer.Dtos.CustomerAccountProcessDtos
{
    public class SendMoneyForCustomerAccountProcessDto
    {
        public string CustomerAccountProcessType { get; set; }
        public decimal CustomerAccountProcessAmount { get; set; }
        public DateTime CustomerAccountProcessDate { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public string ReceiverAccountNumber { get; set; }

        public string Description { get; set; }

    }
}
