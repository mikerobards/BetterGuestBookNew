using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookNewLibrary.Models
{
    public class GuestModel
    {
        public GuestModel(List<GuestModel> guests)
        {
            Guests = guests;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MessageToHost { get; set; }

        public string GuestInfo
        {
            get
            {
                return $"{ FirstName } { LastName }: { MessageToHost }";
            }
        }

        public List<GuestModel> Guests { get; }
    }
}
