using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mango_Cards.Library.Models
{
    public class LoginLog
    {
        public Guid Id { get; set; }
        public string State { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
