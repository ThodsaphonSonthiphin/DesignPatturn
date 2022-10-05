using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    public class Room
    {
        public bool Reserve { get; set; } = false;
        public IMediator? Mediator { get; set; }

        public int RoomNumber { get; set; }

        public void IsReserve()
        {
            if (!Reserve)
            {
                this.Mediator?.NotifyNotReserve(this);
            }
            
        }

        public override string ToString()
        {
            return $"Room number :{RoomNumber}";
        }
    }
}
