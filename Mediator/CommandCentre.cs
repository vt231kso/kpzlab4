using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
  class CommandCentre : ICommandCentre
  {
    private readonly List<Runway> _runways;

    public CommandCentre(List<Runway> runways)
    {
      _runways = runways;
    }

    public void RequestLanding(Aircraft aircraft)
    {
      Console.WriteLine($"Aircraft {aircraft.Name} is requesting landing.");
      foreach (var runway in _runways)
      {
        if (runway.IsBusyWithAircraft == null)
        {
          Console.WriteLine($"Aircraft {aircraft.Name} has landed on runway {runway.Id}.");
          runway.IsBusyWithAircraft = aircraft;
          runway.HighLightRed();
          aircraft.CurrentRunway = runway;
          return;
        }
      }
      Console.WriteLine("No free runways available for landing.");
    }

    public void RequestTakeOff(Aircraft aircraft)
    {
      if (aircraft.CurrentRunway != null)
      {
        Console.WriteLine($"Aircraft {aircraft.Name} is taking off from runway {aircraft.CurrentRunway.Id}.");
        aircraft.CurrentRunway.IsBusyWithAircraft = null;
        aircraft.CurrentRunway.HighLightGreen();
        aircraft.CurrentRunway = null;
      }
      else
      {
        Console.WriteLine($"Aircraft {aircraft.Name} is not assigned to a runway.");
      }
    }
  }
  }
