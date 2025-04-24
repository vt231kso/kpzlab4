using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chainofrespon
{
  class AdminSupportHandler : SupportHandler
  {
    public override bool HandleRequest(string input)
    {
      if (input == "4")
      {
        Console.WriteLine("📞 Ви обрали адміністративну підтримку. Оператор з'єднається з вами.");
        return true;
      }
      return nextHandler?.HandleRequest(input) ?? false;
    }
  }
}
