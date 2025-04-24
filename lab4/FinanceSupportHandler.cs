using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chainofrespon
{
  class FinanceSupportHandler : SupportHandler
  {
    public override bool HandleRequest(string input)
    {
      if (input == "3")
      {
        Console.WriteLine("💰 Ви обрали фінансову підтримку. Оператор з'єднається з вами.");
        return true;
      }
      return nextHandler?.HandleRequest(input) ?? false;
    }
  }
}
