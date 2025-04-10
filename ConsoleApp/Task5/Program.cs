using ConsoleApp.Task5.LightNode;

LightElementNode table = new LightElementNode("table", "block", "pair", new List<string> { "data-table" });
LightElementNode headerRow = new LightElementNode("tr", "block", "pair");
headerRow.AddChild(new LightElementNode("th", "inline", "pair", new List<string> { "header-cell" }));
headerRow.AddChild(new LightElementNode("th", "inline", "pair", new List<string> { "header-cell" }));
table.AddChild(headerRow);

LightElementNode dataRow = new LightElementNode("tr", "block", "pair");
dataRow.AddChild(new LightElementNode("td", "inline", "pair", new List<string> { "data-cell" }));
dataRow.AddChild(new LightElementNode("td", "inline", "pair", new List<string> { "data-cell" }));
table.AddChild(dataRow);

Console.WriteLine(table.OuterHTML());