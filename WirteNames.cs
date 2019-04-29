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

namespace DatabaseProjekt.GameObjects
{
    class WirteNames
    {

        public static string Player1, Player2;
        char bogstav;
        public bool Don =false;
      
        SpriteFont Player1Name;
        SpriteFont Player2Name;
   
        public  WirteNames()
        {
          
            Keyboard.GetState();

        }
       
  

        public void loadContent(ContentManager content)
        {
            Player1Name = content.Load<SpriteFont>("Player_1");

            Player2Name = content.Load<SpriteFont>("Player_2");


        }
            


        public char Writebogstav()
        {
            //Keys key;

           
            //switch (key.)
            //{
            //    case :
            //       Player1 = "feesfsefsea";
                    
            //        break;
               
            //    default:
            //        break;
            //}
            return bogstav;
        }

        public void Write_name1(GameTime gameTime)
        {

           // Writebogstav(Keyboar);

           // Player1 = "fiojsodjf";
        }



        public void Write_Name2()
        {
            Player2 = "oskvgofkesd";
           

        }

        public void Draw(SpriteBatch spriteBatch)
        {
     
            spriteBatch.DrawString(Player1Name, $"{WriteName1.WRITE}  Player 1 Name: {Player1 }" , new Vector2(150, 200 ), Color.Black);
            spriteBatch.DrawString(Player2Name, $"Player 2 Name:{Player2 }", new Vector2(150, 400), Color.Black);
        }


    }
}
