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

namespace DatabaseProjekt
{
    class SetCaravanPriceButton : Componet
    {
        public Vector2 pos;
        public SpriteRender spriteRender { get; private set; }
        public static Vector2 MousePosition;
        DontLookAtMe writePrice = new DontLookAtMe();
        public static string Player1, Player2;
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
        public Rectangle thisrectangle;
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

        public SetCaravanPriceButton()
        {
            pos = new Vector2(GameWorld.Worldzice.X / 2, GameWorld.Worldzice.Y / 2);
            // thisrectangle = ColisionBox;
        }

        public SetCaravanPriceButton(Vector2 Position)
        {

            this.pos = Position;
        }
        public override void Attach(GameObject gameObject)
        {
            spriteRender = (SpriteRender)gameObject.FindCompent("SpriteRender");
            base.Attach(gameObject);
            gameObject.transForm.positon = pos;

        }
        public override void Update(GameTime gameTime)
        {


            MouseState mouse = Mouse.GetState();
            thisrectangle = ColisionBox;


            spriteRender = (SpriteRender)gameObject.FindCompent("SpriteRender");

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
                 
                    break;
                case state.Pressed:
                    //if(GameWorld.CurrentState)
                    CampsiteController.Instance.SetCaravanPrice(Player1 = writePrice.Writebogstav(4), true);
                    break;
                case state.Hover:
                     
                    /// do somthing
                    break;
                default:
                    break;
            }




            base.Update(gameTime);
        }
    }
}
