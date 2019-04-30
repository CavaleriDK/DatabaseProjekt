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
    class StarteButtone : Componet
    {

   

        public Vector2 pos;
        public static string CLICK;
        public static bool Cliket;
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
       
        public StarteButtone()
        {
            pos = new Vector2(GameWorld.Worldzice.X / 2, GameWorld.Worldzice.Y / 2);
        }
        public StarteButtone(Vector2 Position){
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
            ///
            
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
                    spriteRender.color = Color.White;
                   
                    // do somthing 
                    break;
                case state.Pressed:
                    CLICK = "pressed";
                    GameWorld.Remove.Add(this.gameObject);
                    spriteRender.color = Color.Black;
                    foreach (var go in GameWorld.gameObjects)
                    {

                        GameWorld.Remove.Add(go);
                    }

                    Cliket = true;
                    break;
                case state.Hover:
                    CLICK = "Hover";
                    /// do somthing
                    spriteRender.color = Color.Red;
                    break;
                default:
                    break;
            }        
         
         
                     
            


            base.Update(gameTime);
        }
    }
}
