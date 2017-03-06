using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ISMSHandler
    {
        void SendSMS(String tlf, String body);

        void StartSMSApp(String tlf, String body);
    }
}
