using ConsoleApp.Task5.Interface;
using ConsoleApp.Task5.LightNode;

using static System.Console;

LightElementNode table = new LightElementNode("table", "block", "pair", new List<string> { "data-table" });
LightElementNode headerRow = new LightElementNode("tr", "block", "pair");
headerRow.AddChild(new LightElementNode("th", "inline", "pair", new List<string> { "header-cell" }));
headerRow.AddChild(new LightElementNode("th", "inline", "pair", new List<string> { "header-cell" }));
table.AddChild(headerRow);

LightElementNode dataRow = new LightElementNode("tr", "block", "pair");
dataRow.AddChild(new LightElementNode("td", "inline", "pair", new List<string> { "data-cell" }));
dataRow.AddChild(new LightElementNode("td", "inline", "pair", new List<string> { "data-cell" }));
table.AddChild(dataRow);
WriteLine(table.OuterHTML());
ReadKey();


/// Тригер (Спостерігач)
LightElementNode button = new LightElementNode("button", "inline", "pair", new List<string> { "btn" });
button.AddEventListener("click", new ClickEventListener());
button.AddEventListener("mouseover", new ClickEventListener());
button.TriggerEvent("click");
button.TriggerEvent("mouseover");
WriteLine(button.OuterHTML());
ReadKey();


/// Картинка (Стратегія) локально
LightElementNode div = new LightElementNode("div", "block", "pair");
IImageLoader fileLoader = new FileImageLoader();
LightImageNode fileImage = new LightImageNode("./image.jpg", fileLoader);
div.AddChild(fileImage);
ReadKey();


/// Картинка (Стратегія) не локально
IImageLoader networkLoader = new NetworkImageLoader();
LightImageNode networkImage = new LightImageNode("https://images.pexels.com/photos/1213447/pexels-photo-1213447.jpeg", networkLoader);
div.AddChild(networkImage);
WriteLine(div.OuterHTML());
ReadKey();