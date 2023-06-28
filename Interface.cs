namespace CodeSnippets
{
    interface IValue
    {
        void Render();
    }

    class Content : IValue
    {
        public void Render()
        {
            Console.WriteLine("Render content");
        }
    }

    class Image : IValue
    {
        public void Render()
        {
            Console.WriteLine("Render image");
        }
    }
}
