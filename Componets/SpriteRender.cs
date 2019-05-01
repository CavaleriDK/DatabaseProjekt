using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DatabaseProjekt.Componets

{
    public class SpriteRender : Componet
    {
        public string spriteName;
        public Rectangle rectangle { get; set; }
        public Texture2D Sprite;
        public Vector2 Orgin;
        public SpriteRender(string SpriteName)
        {
            this.spriteName = SpriteName;
        }
        /// <summary>
        /// loadsprite down
        /// </summary>
        /// <param name="content"></param>
        public override void LoadContent(ContentManager content)
        {

            Sprite = content.Load<Texture2D>(spriteName);
            rectangle = new Rectangle(0, 0, Sprite.Width, Sprite.Height);
            Orgin = new Vector2(Sprite.Width / 2, Sprite.Height / 2);
        }
        /// <summary>
        /// Draw Sprite;
        /// </summary>
        /// <param name="spriteBatch"></param>
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Sprite, gameObject.transForm.positon, rectangle,
            Color.White, gameObject.transForm.rotetion, Orgin,
            gameObject.transForm.size, gameObject.transForm.s, 0);
        }
    }
}
