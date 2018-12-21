using System;

namespace S01E02_BeSquare
{
    public sealed class Rectangle
    {
        public int Width { get; }
        public int Height { get; }

        public bool IsSquare => Width == Height;

        public Rectangle(int width, int height)
        {
            if (width <= 0)
                throw new ArgumentOutOfRangeException(nameof(width), "Width must be positive.");

            if (height <= 0)
                throw new ArgumentOutOfRangeException(nameof(height), "Height must be positive.");

            Width = width;
            Height = height;
        }
    }
}
