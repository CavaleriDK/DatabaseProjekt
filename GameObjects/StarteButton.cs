using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using DatabaseProjekt.Componets;

namespace DatabaseProjekt.GameObjects
{
    class StarteButton : Componet
    {

        public Vector2 pos;
        public static bool CLICK;
        public SpriteRender spriteRender { get; private set; }
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

        public enum state
        {
            none,
            Pressed,
            Hover,
            Released
        }

        private state _state;
        public state State
        {
            get{ return _state;}            
            set{ _state = value;}
        }

        public static Vector2 mouseposition;
        public static Vector2 ractagposition;
        public StarteButton()
        {
            pos = new Vector2(GameWorld.Worldzice.X / 2, GameWorld.Worldzice.Y/ 2);
                
        }

        public override void Attach(GameObject gameObject)
        {
            base.Attach(gameObject);

            gameObject.transForm.positon = pos;
            
            //colider = (Colider)gameObject.FindCompent("Colider");



        }
        public override void Update(GameTime gameTime)
        {
            spriteRender = (SpriteRender)gameObject.FindCompent("SpriteRender");
            MouseState mouse = Mouse.GetState();
            mouseposition.X = mouse.X;
            mouseposition.Y = mouse.Y;
            ractagposition.X = spriteRender.rectangle.X;
            ////if (mouse.LeftButton == ButtonState.Pressed)
            ////{
            ////    State = state.Pressed;
            ////}
            ////else
            ////{
            ////    State = state.Hover;
            ////}

            if (ColisionBox.Contains(mouseposition.X, mouseposition.Y))
            {
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    State = state.Pressed;
                }
                else
                {
                    State = state.Hover;
                }

            }
            //else
            //{
            //    State = state.none;
            //}

            switch (State)  
            {
                case state.none:
                 
                    break;
                case state.Pressed:
                    CLICK = true;
                    break;
                case state.Hover:
                    break;
                case state.Released:
                    CLICK = false;
                    break;
                default:
                    break;
            }

            base.Update(gameTime);
        }


        public override void LoadContent(ContentManager content)
        {
            texture = content.Load<Texture2D>("CollisionTexture");
        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            Rectangle topLine = new Rectangle(ColisionBox.X, ColisionBox.Y, ColisionBox.Width, 1);
            Rectangle bottomLine = new Rectangle(ColisionBox.X, ColisionBox.Y + ColisionBox.Height, ColisionBox.Width, 1);
            Rectangle rightLine = new Rectangle(ColisionBox.X + ColisionBox.Width, ColisionBox.Y, 1, ColisionBox.Height);
            Rectangle leftLine = new Rectangle(ColisionBox.X, ColisionBox.Y, 1, ColisionBox.Height);

            spriteBatch.Draw(texture, topLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
            spriteBatch.Draw(texture, bottomLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
            spriteBatch.Draw(texture, rightLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
            spriteBatch.Draw(texture, leftLine, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
            //  spriteBatch.Draw(texture,ColisionBox, null, Color.Red, 0, Vector2.Zero, SpriteEffects.None, 1);
        }
    }
}
