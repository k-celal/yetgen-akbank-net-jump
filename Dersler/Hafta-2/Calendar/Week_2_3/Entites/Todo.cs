using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_2_3MX.Abstarct;
using Week_2_3MX.Common;

namespace Week_2_3MX.Entites
{

    internal class ToDo : Event, INotification
    {
    public string Importance { get; set; }

    public void GetNotification()
    {
        Console.WriteLine($"Time to make this to-do: {Title}");
    }

    }
}
