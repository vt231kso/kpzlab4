namespace Memento
{

  class Program
  {
    static void Main(string[] args)
    {
      var document = new TextDocument();
      var editor = new TextEditor(document);
      var caretaker = new Caretaker();

      editor.TypeText("Версія 1");
      caretaker.Save(editor.SaveState());

      editor.TypeText("Версія 2");
      caretaker.Save(editor.SaveState());

      editor.TypeText("Версія 3");
      Console.WriteLine("Поточний текст: " + editor.GetContent());

      editor.RestoreState(caretaker.Undo());
      Console.WriteLine("Скасування → " + editor.GetContent());

      editor.RestoreState(caretaker.Undo());
      Console.WriteLine("Скасування → " + editor.GetContent());
    }
  }



}
