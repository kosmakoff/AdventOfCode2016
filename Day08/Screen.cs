using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    public class Screen
    {
        private readonly int _screenWidth;
        private readonly int _screenHeight;
        public BitArray ScreenBits { get; }

        public Screen(int screenWidth, int screenHeight)
        {
            if (screenWidth <= 0)
                throw new ArgumentException("Must be greater than zero.", nameof(screenWidth));

            if (screenHeight <= 0)
                throw new ArgumentException("Must be greater than zero.", nameof(screenHeight));

            _screenWidth = screenWidth;
            _screenHeight = screenHeight;
            ScreenBits = new BitArray(screenWidth*screenHeight, false);
        }

        public void Fill(int width, int height)
        {
            if (width < 0 || width >= _screenWidth)
                throw new ArgumentException($"Must be in range 0-{_screenWidth - 1}.", nameof(width));

            if (height < 0 || height >= _screenHeight)
                throw new ArgumentException($"Must be in range 0-{_screenHeight - 1}.", nameof(height));

            for (int y = 0; y < height; y++)
                for (int x = 0; x < width; x++)
                    ScreenBits.Set(GetMemAddress(x, y), true);
        }

        public void ShiftColumn(int columnNumber, int count)
        {
            if (columnNumber < 0 || columnNumber >= _screenWidth)
                throw new ArgumentException($"Must be in range 0-{_screenWidth - 1}.", nameof(columnNumber));

            var modCount = count%_screenHeight;

            if (modCount == 0)
                return;

            var tempBits = new bool[modCount];

            for (int i = 0; i < modCount; i++)
                tempBits[i] = ScreenBits[GetMemAddress(columnNumber, _screenHeight - modCount + i)];

            for (int i = 0; i < _screenHeight - modCount; i++)
                ScreenBits[GetMemAddress(columnNumber, _screenHeight - 1 - i)] = ScreenBits[GetMemAddress(columnNumber, _screenHeight - 1 - i - modCount)];

            for (int i = 0; i < modCount; i++)
                ScreenBits[GetMemAddress(columnNumber, i)] = tempBits[i];
        }

        public void ShiftRow(int rowNumber, int count)
        {
            if (rowNumber < 0 || rowNumber >= _screenHeight)
                throw new ArgumentException($"Must be in range 0-{_screenHeight - 1}.", nameof(rowNumber));

            var modCount = count%_screenWidth;

            if (modCount == 0)
                return;

            var tempBits = new bool[modCount];

            for (int i = 0; i < modCount; i++)
                tempBits[i] = ScreenBits[GetMemAddress(_screenWidth - modCount + i, rowNumber)];

            for (int i = 0; i < _screenWidth - modCount; i++)
                ScreenBits[GetMemAddress(_screenWidth - 1 - i, rowNumber)] = ScreenBits[GetMemAddress(_screenWidth - 1 - i - modCount, rowNumber)];

            for (int i = 0; i < modCount; i++)
                ScreenBits[GetMemAddress(i, rowNumber)] = tempBits[i];
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            for (int y = 0; y < _screenHeight; y++)
            {
                for (int x = 0; x < _screenWidth; x++)
                    sb.Append(ScreenBits[GetMemAddress(x, y)] ? '#' : '.');

                sb.AppendLine();
            }

            return sb.ToString();
        }

        private int GetMemAddress(int x, int y)
        {
            return y*_screenWidth + x;
        }
    }
}
