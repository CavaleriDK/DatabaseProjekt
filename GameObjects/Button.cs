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
    class Button : Componet
    {

   

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
       
        public Button()
        {
            pos = new Vector2(GameWorld.Worldzice.X / 2, GameWorld.Worldzice.Y / 2);
        }
        public Button(Vector2 Position){
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
/// 
            switch (spriteRender.spriteName)
            {
                case "StartKnap":
                    switch (State)
                    {
                        case state.none:
                            CLICK = "non";
                            // do somthing 
                            break;
                        case state.Pressed:
                            CLICK = "pressed";
                            // do SOmthing
                            break;
                        case state.Hover:
                            CLICK = "Hover";
                            /// do somthing
                            break;
                        default:
                            break;
                    }
                    break;

                case "ExitKnap":
                    switch (State)
                    {
                        case state.none:
                            CLICK = "non";
                            // do somthing 
                            break;
                        case state.Pressed:
                            CLICK = "OHDOGODGD";

                            // do SOmthing
                            break;
                        case state.Hover:
                            CLICK = "Hover";
                            /// do somthing
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
                    
                     
            }

            //switch (State)
            //{
            //    case state.none:
            //        CLICK = "non";
            //        // do somthing 
            //        break;
            //    case state.Pressed:
            //        CLICK = "pressed";
            //        // do SOmthing
            //        break;
            //    case state.Hover:
            //        CLICK = "Hover";
            //        /// somthing
            //        break;
            //    default:
            //        break;
            //}

            base.Update(gameTime);
        }
    }
}
