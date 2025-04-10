using static System.Console;
using ConsoleApp.Task4.Smart;


WriteLine("Testing SmartTextChecker:");

SmartTextChecker checker = new SmartTextChecker("test.txt");
var content = checker.ReadText();

if (content != null)
{
    foreach (var line in content)
    {
        WriteLine(new string(line));
    }
}

WriteLine("Testing SmartTextReaderLocker:");

SmartTextReaderLocker locker = new SmartTextReaderLocker("test.txt", @"^test\.txt$");
var lockedContent = locker.ReadText();

if (lockedContent != null)
{
    foreach (var line in lockedContent)
    {
        WriteLine(new string(line));
    }
}