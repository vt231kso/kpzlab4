using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
  public class Memento
  {
    private readonly string _content;

    public Memento(string content)
    {
      _content = content;
    }

    public string GetContent()
    {
      return _content;
    }
  }


}
