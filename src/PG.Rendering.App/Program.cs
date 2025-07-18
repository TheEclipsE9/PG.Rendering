using PG.Rendering.Engine;

class Program
{
    static void Main()
    {
        using (MyGame game = new MyGame())
        {
            game.Run();
        }
    }
}