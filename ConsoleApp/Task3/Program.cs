using ConsoleApp.Task;
using static System.Console;

TextEditor editor = new TextEditor();

editor.Write("Hello");
editor.Show();

editor.Write(", world!");
editor.Show();

editor.Undo();
editor.Show();

editor.Undo();
editor.Show();

ReadKey();