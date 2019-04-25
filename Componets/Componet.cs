using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DatabaseProjekt.Componets
{
    abstract public class Componet
    {
        public GameObject gameObject { get; private set; }

        public virtual void Attach(GameObject GameObject)
        {
            this.gameObject = GameObject;
        }
        public virtual void Update(GameTime gameTime)
        {
        }
        public virtual void LoadContent(ContentManager content)
        {
        }
        public virtual void Draw(SpriteBatch spriteBatch)
        {
        }
    }
}
