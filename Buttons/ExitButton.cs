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
    class ExitButton : Componet
    {

        public Vector2 pos;
        public static string CLICK;
        public SpriteRender spriteRender { get; private set; }
        public static Vector2 MousePosition;
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

        public ExitButton()
        {
            pos = new Vector2(GameWorld.Worldzice.X / 2, GameWorld.Worldzice.Y / 2);
        }
        public ExitButton(Vector2 Position)
        {
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
            MousePosition.X = mouse.X;
            MousePosition.Y = mouse.Y;
            ///checks om musen er inden for knappends område og om der bliver 
            ///clickt elelr hovert
           
            if (ColisionBox.Contains(MousePosition.X, MousePosition.Y))
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
             
                   
                    switch (State)
                    {
                        case state.none:
                            CLICK = "non";
                            // do somthing 
                            break;
                        case state.Pressed:
                            CLICK = "OHDOGODGD";
                    GameWorld.ExitGame = true;
                            break;
                        case state.Hover:
                            CLICK = "Hover";
                            /// do somthing
                            break;
                        default:
                            break;
                    }
            


            
            base.Update(gameTime);
        }
    }
}
