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
         DontLookAtMe Write;


        public static string Player1, Player2;



        public WirteNames()
        {


            Write = new DontLookAtMe();
            Keyboard.GetState();
        }



        /// <summary>
        /// loding Wirte NAmes And startspil buttoon
        /// </summary>
        /// <param name="content"></param>
        public void loadContent(ContentManager content)
        {
            GameWorld.gameObjects.Add(ObejteFactory.Insteance.Create("writenameher2", content));
            GameWorld.gameObjects.Add(ObejteFactory.Insteance.Create("writenameher", content));
            GameWorld.gameObjects.Add(ObejteFactory.Insteance.Create("StartSpil", new Vector2(900, 300), content));



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
