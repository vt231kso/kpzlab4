namespace Chainofrespon
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var basic = new BasicSupportHandler();
      var tech = new TechSupportHandler();
      var finance = new FinanceSupportHandler();
      var admin = new AdminSupportHandler();

      basic.SetNextHandler(tech);
      tech.SetNextHandler(finance);
      finance.SetNextHandler(admin);

      bool handled = false;

      do
      {
        Console.WriteLine("\nВітаємо в службі підтримки. Оберіть опцію:");
        Console.WriteLine("1 – Базова підтримка");
        Console.WriteLine("2 – Технічна підтримка");
        Console.WriteLine("3 – Фінансова підтримка");
        Console.WriteLine("4 – Адміністративна підтримка");
        Console.Write("Ваш вибір: ");
        string input = Console.ReadLine();

        handled = basic.HandleRequest(input);

        if (!handled)
        {
          Console.WriteLine("Невідома опція. Спробуйте ще раз.");
        }

      } while (!handled);
    }
  }
}
