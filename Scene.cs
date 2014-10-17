using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Arkanoid
{
    abstract class Scene
    {
        public abstract void Update() { }
        public abstract void Draw(System.Drawing.Graphics g);
        public abstract void KeyboardInputHandler(System.Windows.Forms.KeyEventArgs e, bool keyDown);
    }
}
