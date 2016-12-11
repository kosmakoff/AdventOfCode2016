namespace Day08
{
    public abstract class ScreenCommand
    {
        public abstract void Execute(Screen screen);
    }

    public class RectCommand : ScreenCommand
    {
        public int Width { get; }

        public int Height { get; }

        public RectCommand(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override void Execute(Screen screen)
        {
            screen.Fill(Width, Height);
        }
    }

    public class ShiftRowCommand : ScreenCommand
    {
        public int RowNumber { get; }

        public int Count { get; }

        public ShiftRowCommand(int rowNumber, int count)
        {
            RowNumber = rowNumber;
            Count = count;
        }

        public override void Execute(Screen screen)
        {
            screen.ShiftRow(RowNumber, Count);
        }
    }

    public class ShiftColumnCommand : ScreenCommand
    {
        public int ColumnNumber { get; }

        public int Count { get; }

        public ShiftColumnCommand(int columnNumber, int count)
        {
            ColumnNumber = columnNumber;
            Count = count;
        }

        public override void Execute(Screen screen)
        {
            screen.ShiftColumn(ColumnNumber, Count);
        }
    }
}