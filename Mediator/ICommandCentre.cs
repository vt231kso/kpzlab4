using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
  interface ICommandCentre
  {
    void RequestLanding(Aircraft aircraft);
    void RequestTakeOff(Aircraft aircraft);
  }
}
