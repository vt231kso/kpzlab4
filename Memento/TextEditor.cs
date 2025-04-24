using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
  public class TextEditor
  {
    private readonly TextDocument _document;

    public TextEditor(TextDocument document)
    {
      _document = document;
    }

    public void TypeText(string text)
    {
      _document.Update(text);
    }

    public string GetContent()
    {
      return _document.GetContent();
    }

    public Memento SaveState()
    {
      return new Memento(_document.GetContent());
    }

    public void RestoreState(Memento memento)
    {
      _document.Update(memento.GetContent());
    }
  }


}
