using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
  public class TextDocument
  {
    private string _content = "";

    public void Update(string text)
    {
      _content = text;
    }

    public string GetContent()
    {
      return _content;
    }
  }

}
