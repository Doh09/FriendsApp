using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IDialer
    {       
        /// <summary>
        /// Open up the phone calling app, with number set as the phone number, but without calling.
        /// </summary>
        /// <param name="number"></param>
        void StartDial(string number);
        /// <summary>
        /// Open up the phone calling app, afterwards the number is called.
        /// </summary>
        void Call(string number);
    }
}
