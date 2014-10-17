using System;
using System.Drawing;

namespace Arkanoid
{
    class Menu : Scene
    {
        private Image background;

        public Menu() { this.background = Image.FromFile(@"...\..\Images\MenuBackground.jpg"); }
      
        public override void Update() { }

        public override void Draw(Graphics g) { g.DrawImage(this.background, new Point(0, 0)); }

        public override void GetKeyPressed(System.Windows.Forms.KeyEventArgs e){
            if (e.KeyCode.Equals(System.Windows.Forms.Keys.Return)) SceneManager.GetInstance().CurrScene = new Level();
        }

        public override void GetKeyUnpressed(System.Windows.Forms.KeyEventArgs e) { }
    }
}
