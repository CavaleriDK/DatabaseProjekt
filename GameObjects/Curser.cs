using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseProjekt.Componets;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DatabaseProjekt.GameObjects
{
    class Curser: Componet
    {
        public Vector2 Position;

        public Curser()
        {
            Position = new Vector2(300, 300);
        }

        public override void Update(GameTime gameTime)
        {

            MouseState mouse = Mouse.GetState();

            Position.X = mouse.X;
            Position.Y = mouse.Y;

            gameObject.transForm.positon = Position;
        }


        public override void Attach(GameObject gameObject)
        {
            base.Attach(gameObject);
            gameObject.transForm.positon = Position;

        }


        public void Reset()
        {
            gameObject.transForm.positon = Position;
        }
    }
}
