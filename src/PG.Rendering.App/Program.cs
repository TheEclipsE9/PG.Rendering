using PG.Rendering.Engine;

class Program
{
    static void Main()
    {
        using var game = new MyGame();
        game.Run();
    }
}