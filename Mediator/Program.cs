namespace Mediator
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var runways = new List<Runway> { new Runway(), new Runway() };
      var commandCentre = new CommandCentre(runways);

      var aircraft1 = new Aircraft("Boeing 737", commandCentre);
      var aircraft2 = new Aircraft("Airbus A320", commandCentre);

      aircraft1.RequestLanding();
      aircraft2.RequestLanding();
      aircraft1.RequestTakeOff();
      aircraft2.RequestTakeOff();
    }
  }
}
