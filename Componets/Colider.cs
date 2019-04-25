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
    public class Colider : Componet
    {
        public SpriteRender spriteRender { get; private set; }

        public bool CheckColision { get; set; }

        private Texture2D texture;

        public Rectangle ColisionBox
        {
            get
            {
                return new Rectangle
                (
                      (int)(gameObject.transForm.positon.X - spriteRender.Orgin.X),
                        (int)(gameObject.transForm.positon.Y - spriteRender.Orgin.Y),
                        spriteRender.rectangle.Width,
                        spriteRender.rectangle.Height
                );
            }
        }

        private HashSet<Colider> otherColliders = new HashSet<Colider>();


        public override void Attach(GameObject GameObject)
        {

            base.Attach(GameObject);

            CheckColision = true;

            spriteRender = (SpriteRender)GameObject.FindCompent("SpriteRender");



        }

        public override void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("CollisionTexture");
        }


        //public override void Draw(SpriteBatch spriteBatch)
        //{
        //    Rectangle topLine = new Rectangle(ColisionBox.X, ColisionBox.Y, ColisionBox.Width, 1);
        //    Rectangle bottomLine = new Rectangle(ColisionBox.X, ColisionBox.Y + ColisionBox.Height, ColisionBox.Width, 1);
        //    Rectangle rightLine = new Rectangle(ColisionBox.X + ColisionBox.Width, ColisionBox.Y, 1, ColisionBox.Height);
        //    Rectangle leftLine = new Rectangle(ColisionBox.X, ColisionBox.Y, 1, ColisionBox.Height);

        //    spriteBatch.Draw(texture, topLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
        //    spriteBatch.Draw(texture, bottomLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
        //    spriteBatch.Draw(texture, rightLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
        //    spriteBatch.Draw(texture, leftLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
        //    //  spriteBatch.Draw(texture,ColisionBox, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
        //}

    }
}
