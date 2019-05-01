using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using DatabaseProjekt.Componets;

namespace DatabaseProjekt.GameObjects
{
    class WriteName1:Componet
    {

        public static bool WRITE = false;
        WirteNames Names;
        public Vector2 pos;
        public static string CLICK;
     
        public SpriteRender spriteRender { get; private set; }
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
            get { return _state; }
            set { _state = value; }
        }

        public WriteName1()
        {
            Names = new WirteNames();
            pos = new Vector2(GameWorld.Worldzice.X / 2, GameWorld.Worldzice.Y / 2);
        }
        public WriteName1(Vector2 Position)
        {
            Names = new WirteNames();
            this.pos = Position;
        }
        public override void Attach(GameObject gameObject)
        {
            base.Attach(gameObject);
            gameObject.transForm.positon = pos;

        }
        public override void Update(GameTime gameTime)
        {
            spriteRender = (SpriteRender)gameObject.FindCompent("SpriteRender");
            MouseState mouse = Mouse.GetState();
            ///checks om musen er inden for knappends område og om der bliver 
            ///clickt elelr hovert
            if (ColisionBox.Contains(mouse.X, mouse.Y))
            {
                if (mouse.LeftButton == ButtonState.Pressed)
                {
                    State = state.Pressed;
                }
                if (mouse.LeftButton == ButtonState.Released)
                {
                    State = state.Hover;
                }
            }
            else
            {
                State = state.none;
            }
            /// maybe losning


            switch (State)
            {
                case state.none:
                    CLICK = "non";
                    // do somthing 
                    spriteRender.color = Color.White;
                    gameObject.transForm.size = 1;
                    break;
                case state.Pressed:
                    CLICK = "pressed";
                    spriteRender.color = Color.Gray;
                    WRITE = true;
                    break;
                case state.Hover:
                    CLICK = "Hover";
                    spriteRender.color = Color.Salmon;
                    gameObject.transForm.size = 1.5f;
                    /// do somthing
                    break;
                default:
                    break;
            }

            if(WRITE == true)
            {

                Names.Write_name1(gameTime);
                if (Keyboard.GetState().IsKeyDown(Keys.Enter))
                {
                    /// smed player1 name i database Hvis vi skal kunne huske det
                    WRITE = false;
                }
            }

         



            base.Update(gameTime);
        }
        
    }
}
