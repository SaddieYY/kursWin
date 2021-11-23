using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace kursWin
{
    //клас ColorElem - для офомлення кольорів візуальних елементів
    static class ColorElem
    {
        static public Color ButtonForeColor { get => Color.FromArgb(33, 34, 39); }
        static public Color ButtonBackColor { get => Color.FromArgb(170, 185, 207); }
        static public Color BorderColor     { get => Color.FromArgb(33, 34, 39); }
        static public Color ForeColor       { get => Color.FromArgb(33, 34, 39); }
        static public Color BackColor       { get => Color.FromArgb(189, 212, 231); }
    }
}
