using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NConsoleGraphics;

namespace SnakeGameReborn
{
    class PlayZone
    {
        private const uint _color =;
        private int _x;
        private int _y;
        private int _size;
        public PlayZone(int X, int Y, int Size)
        {
            _x = X;
            _y = Y;
            _size = Size;
        }
        public PlayZone(PlayZone play)
        {
            _x = play._x;
            _y = play._y;
            _size = play._size;
        }

        public bool HitPlayZone(PlayZone play)
        {
            return play._x == _x && play._y == _y;
        }
        public void Moving(int outside, int sizeField, Keys moves)
        {
            if (moves == Keys.RIGHT)
            {
                _x += outside;
            }
            else if (moves == Keys.LEFT)
            {
                _x -= outside;
            }
            else if (moves == Keys.UP)
            {
                _y -= outside;
            }
            else if (moves == Keys.DOWN)
            {
                _y += outside;
            }
            if (_x + _size > sizeField)
            {
                _x = 0;
            }
            else if (_x < 0)
            {
                _x = sizeField - _size;
            }
            if (_y + _size > sizeField)
            {
                _y = 0;
            }
            else if (_y < 0)
            {
                _y = sizeField - _size;
            }
        }
    }
}
