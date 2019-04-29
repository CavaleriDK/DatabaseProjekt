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
    class Writename2 : Componet
    {

        WirteNames wirteNames;

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
        /// <summary>
        /// Constructor1
        /// </summary>
        public Writename2()
        {
            wirteNames = new WirteNames();
            pos = new Vector2(GameWorld.Worldzice.X / 2, GameWorld.Worldzice.Y / 2);
        }
        /// <summary>
        /// >Constructor2 kan adde position
        /// </summary>
        /// <param name="Position"></param>
        public Writename2(Vector2 Position)
        {
            wirteNames = new WirteNames();
            this.pos = Position;
        }
        /// <summary>
        /// sætter position
        /// </summary>
        /// <param name="gameObject"></param>
        public override void Attach(GameObject gameObject)
        {
            base.Attach(gameObject);
            gameObject.transForm.positon = pos;

            
        }

        /// <summary>
        /// henter gameobets spriterender ned for at finde rectanglen 
        /// collision patting 
        /// </summary>
        /// <param name="gameTime"></param>
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
                    break;
                case state.Pressed:
                    CLICK = "pressed";
                    wirteNames.Write_Name2();
                        Cliket = true;
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
