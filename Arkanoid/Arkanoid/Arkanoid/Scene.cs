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
        private abstract void Draw(Graphics g);
        private abstract void Update();
        private abstract void KeyPressed(EventArgs e);
        private abstract void KeyUnpressed(EventArgs e);
    }
}
