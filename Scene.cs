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
        protected abstract void Draw(Graphics g);
        public abstract void Update();
        public abstract void KeyPressed(EventArgs e);
        public abstract void KeyUnpressed(EventArgs e);
    }
}
