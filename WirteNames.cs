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

  

        DontLookAtMe Write;

        public static string Player1, Player2;
        
        public  WirteNames()
        {
            Write = new DontLookAtMe();
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

        private static string removeLastChar(string str)
        {
            if (str.Length >= 1)
            {
                return str.Substring(0, str.Length - 1);
            }
            return str;         
        }    

        public void Write_name1()
        {      

         Player1 =  Write.Writebogstav(15);
        }

        public void Write_Name2()
        {
         Player2 = Write.Writebogstav(15);
        }
    

    }
}
