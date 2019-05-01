using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using DatabaseProjekt.Componets;
using DatabaseProjekt.Factorys;
using DatabaseProjekt.GameState;
namespace DatabaseProjekt.GameObjects
{
    class WirteNames
    {

        KeyboardState laststate = new KeyboardState();

        DontLookAtMe Write;

        public static string Player1, Player2;
       
        public bool Don =false;
        public bool NameLength;
        SpriteFont Player1Name;
        SpriteFont Player2Name;
   
        public  WirteNames()
        {
            Write = new DontLookAtMe();
            Keyboard.GetState();

        }
       
  

        public void loadContent(ContentManager content)
        {
           
            //Player1Name = content.Load<SpriteFont>("Player_1");
            //GameWorld.gameObjects.Add(ObejteFactory.Insteance.Create()
            //Player2Name = content.Load<SpriteFont>("Player_2");


        }

        private static string removeLastChar(string str)
        {
            if (str.Length >= 1)
            {
                return str.Substring(0, str.Length - 1);
            }
            return str;
           
        }

       

        public void Write_name1(GameTime gameTime)
        {

            Player1 = Write.Writebogstav(15);
            CampsiteController.Instance.AddCampsiteByName(Player1, true);
        }

        public void Write_Name2()
        {
            Player2 = Write.Writebogstav(15);
            CampsiteController.Instance.AddCampsiteByName(Player2, false);
        }
        
        public void Draw(SpriteBatch spriteBatch)
        {
     
            //spriteBatch.DrawString(Player1Name, $"Player 1 Name:{Player1 }", new Vector2(150, 200 ), Color.Black);
            //spriteBatch.DrawString(Player2Name, $"Player 2 Name:{Player2 }", new Vector2(150, 400), Color.Black);
        }


    }
}
