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
<<<<<<< HEAD
<<<<<<< HEAD
        SpriteFont Player1Name;
        SpriteFont Player2Name;
=======
        public static bool Cliket;
>>>>>>> parent of 92b7f50... lsl
=======
        public static bool Cliket;
>>>>>>> parent of 92b7f50... lsl
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
        public override void LoadContent(ContentManager content)
        {
            Player1Name = content.Load<SpriteFont>("Player_1");
            Player2Name = content.Load<SpriteFont>("Player_2");

            base.LoadContent(content);
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
                    break;
                case state.Pressed:
<<<<<<< HEAD
                    CLICK = "pressed";                
                    WRITE = true;
                    break;
                case state.Hover:                            
                    gameObject.transForm.size = 1.2f;
=======
                    CLICK = "pressed";

                    WRITE = true;
                    break;
                case state.Hover:
                    CLICK = "Hover";
>>>>>>> parent of ef49daa... dghdfg
                    /// do somthing
                    break;
                default:
                    break;
            }

            if(WRITE == true)
            {

                Names.Write_name1();
                if (Keyboard.GetState().IsKeyDown(Keys.Enter))

                {
                    
                    WRITE = false;
                }
            }

         



            base.Update(gameTime);
        }
        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(Player1Name, $"Player 1 Name:{WirteNames.Player1 }", new Vector2(250, 100), Color.Black);
            spriteBatch.DrawString(Player2Name, $"Player 2 Name:{WirteNames.Player2 }", new Vector2(250, 600), Color.Black);
            base.Draw(spriteBatch);
        }

    }
}
