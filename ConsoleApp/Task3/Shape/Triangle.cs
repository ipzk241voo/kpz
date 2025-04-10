using ConsoleApp.Task3.Interface;
namespace ConsoleApp.Task3.Shape
{
    internal class Triangle: Shape
    {
        public Triangle(IRenderer Renderer) : base(Renderer) { }

        public override void Draw()
        {
            Renderer.Render("Triangle");
        }
    }
}
