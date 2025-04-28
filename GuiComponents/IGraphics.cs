namespace GuiComponents;

public interface IGraphics
{
    public void DrawText(int x, int y, string text);
    public void DrawRectangle(int x, int y, int width, int height);
    public void DrawLine(int x1, int y1, int x2, int y2);
    public void OffsetX(int offset);
}