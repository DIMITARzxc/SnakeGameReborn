using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;
namespace SnakeGameReborn
{
    class Canvas
    {
        private int _width;
        private int _height;
        private uint _color;
        public Canvas(int clientWidth,int clientHeight, uint color)
        {
            _width = clientHeight;
            _height = clientHeight;
            _color = color;
        }
        public void Draw(ConsoleGraphics graphics)
        {
            graphics.FillRectangle(_color, 0, 0, _width, _height);
        }

    }
}
