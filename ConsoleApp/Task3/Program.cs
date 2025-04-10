using ConsoleApp.Task3.Interface;
using ConsoleApp.Task3.Render;
using ConsoleApp.Task3.Shape;

IRenderer raster = new RasterRenderer();
IRenderer vector = new VectorRenderer();

Shape triangle = new Triangle(raster);
Shape circle = new Cricle(vector);
Shape square = new Square(raster);

triangle.Draw(); 
circle.Draw();   
square.Draw(); 