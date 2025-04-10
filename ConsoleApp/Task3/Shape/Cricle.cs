using ConsoleApp.Task3.Interface;
namespace ConsoleApp.Task3.Shape
{
    internal class Cricle : Shape
    {
        public Cricle(IRenderer Renderer) : base(Renderer) {}

        public override void Draw()
        {
            Renderer.Render("Circle");
        }
    }
}
