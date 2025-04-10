using ConsoleApp.Task3.Interface;
namespace ConsoleApp.Task3.Shape
{
    internal abstract class Shape
    {
        protected IRenderer Renderer;

        public Shape(IRenderer Renderer)
        {
            this.Renderer = Renderer;
        }

        public abstract void Draw();
    }
}
