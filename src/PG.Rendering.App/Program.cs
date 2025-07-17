using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;

class Program
{
    static void Main()
    {
        using var game = new MyGame();
        game.Run();
    }
}

class MyGame : GameWindow
{
    public MyGame() : base(GameWindowSettings.Default, NativeWindowSettings.Default) {}

    protected override void OnLoad()
    {
        GL.ClearColor(0.1f, 0.2f, 0.3f, 1.0f);
        base.OnLoad();
    }

    protected override void OnRenderFrame(OpenTK.Windowing.Common.FrameEventArgs args)
    {
        GL.Clear(ClearBufferMask.ColorBufferBit);
        SwapBuffers();
        base.OnRenderFrame(args);
    }
}