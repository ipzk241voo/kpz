using ConsoleApp.Task3.Interface;
namespace ConsoleApp.Task3.Shape
{
    internal class Square : Shape
    {
        public Square(IRenderer Renderer) : base(Renderer) { }

        public override void Draw()
        {
            Renderer.Render("Square");
        }
    }
}
