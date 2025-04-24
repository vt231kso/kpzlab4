using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
  public class Caretaker
  {
    private readonly Stack<Memento> _history = new Stack<Memento>();

    public void Save(Memento memento)
    {
      _history.Push(memento);
    }

    public Memento Undo()
    {
      if (_history.Count > 0)
        return _history.Pop();

      return null;
    }
  }

}
