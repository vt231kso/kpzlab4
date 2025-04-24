using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chainofrespon
{
  class BasicSupportHandler : SupportHandler
  {
    public override bool HandleRequest(string input)
    {
      if (input == "1")
      {
        Console.WriteLine("Ви обрали базову підтримку. Оператор з'єднається з вами.");
        return true;
      }
      return nextHandler?.HandleRequest(input) ?? false;
    }
  }

}
