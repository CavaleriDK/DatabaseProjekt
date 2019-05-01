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
<<<<<<< HEAD
using DatabaseProjekt.Factorys;
using DatabaseProjekt.GameState;
using DatabaseProjekt.Buttons;
=======

>>>>>>> parent of 59b57df...  mmklpp
namespace DatabaseProjekt.GameObjects
{
    class WirteNames
    {

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
  

        DontLookAtMe Write;

        public static string Player1, Player2;
        
=======
        public static string Player1, Player2;
=======
        public static string Player1, Player2;
>>>>>>> parent of 92b7f50... lsl
=======
        public static string Player1, Player2;
>>>>>>> parent of 92b7f50... lsl
        char bogstav;
        public bool Don =false;
      
        SpriteFont Player1Name;
        SpriteFont Player2Name;
   
>>>>>>> parent of 92b7f50... lsl
        public  WirteNames()
        {
          
            Keyboard.GetState();

        }
       
        public void loadContent(ContentManager content)
        {
<<<<<<< HEAD
           
            GameWorld.gameObjects.Add(ObejteFactory.Insteance.Create("writenameher2", content));
            GameWorld.gameObjects.Add(ObejteFactory.Insteance.Create("writenameher", content));
            GameWorld.gameObjects.Add(ObejteFactory.Insteance.Create("StartKnap", new Vector2(900, 300), content));
=======
            Player1Name = content.Load<SpriteFont>("Player_1");

            Player2Name = content.Load<SpriteFont>("Player_2");


>>>>>>> parent of 59b57df...  mmklpp
        }
            
<<<<<<< HEAD


        public char Writebogstav()
        {
<<<<<<< HEAD
<<<<<<< HEAD
            if (str.Length >= 1)
            {
                return str.Substring(0, str.Length - 1);
            }
<<<<<<< HEAD
            return str;         
        }    
=======
            return str;
=======
            //Keys key;

>>>>>>> parent of 92b7f50... lsl
=======
            //Keys key;

>>>>>>> parent of 92b7f50... lsl
=======


        public char Writebogstav()
        {
            //Keys key;

>>>>>>> parent of 92b7f50... lsl
           
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
>>>>>>> parent of 882ed82... fed

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        public void Write_name1()
        {      
=======
>>>>>>> parent of 92b7f50... lsl
=======
>>>>>>> parent of 92b7f50... lsl
=======
>>>>>>> parent of 92b7f50... lsl


        public void Write_Name2()
        {
            Player2 = "oskvgofkesd";
           

        }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
    
=======
        
=======

>>>>>>> parent of 92b7f50... lsl
=======

>>>>>>> parent of 92b7f50... lsl
=======

>>>>>>> parent of 92b7f50... lsl
        public void Draw(SpriteBatch spriteBatch)
        {
     
            spriteBatch.DrawString(Player1Name, $"{WriteName1.WRITE}  Player 1 Name: {Player1 }" , new Vector2(150, 200 ), Color.Black);
            spriteBatch.DrawString(Player2Name, $"Player 2 Name:{Player2 }", new Vector2(150, 400), Color.Black);
        }

>>>>>>> parent of 882ed82... fed

    }
}
