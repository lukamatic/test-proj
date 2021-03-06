using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Model.RabbitMQMessages
{
    public class NewTenderMessage
    {
        public Guid Apikey { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<MedicationRequestMessage> MedicationRequestDto { get; set; }
    }
}
