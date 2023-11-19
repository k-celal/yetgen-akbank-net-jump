using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_2_3MX.Abstarct;
using Week_2_3MX.Common;

namespace Week_2_3MX.Entites
{
    internal class Meeting : Event, INotification
    {
        public List<string> Guests { get; set; }

        public void GetNotification() 
        {
            foreach (var guest in Guests)
            {
                Console.WriteLine($"Inviting: {guest}");
            }
        }
    }
}
