using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
  class Aircraft
  {
    public string Name { get; }
    public bool IsTakingOff { get; set; } = false;
    public Runway? CurrentRunway { get; set; }
    private readonly ICommandCentre _commandCentre;

    public Aircraft(string name, ICommandCentre commandCentre)
    {
      Name = name;
      _commandCentre = commandCentre;
    }

    public void RequestLanding()
    {
      _commandCentre.RequestLanding(this);
    }

    public void RequestTakeOff()
    {
      _commandCentre.RequestTakeOff(this);
    }
  }
}
