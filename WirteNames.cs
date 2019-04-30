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
            Player1Name = content.Load<SpriteFont>("Player_1");

            Player2Name = content.Load<SpriteFont>("Player_2");


        }

        private static string removeLastChar(string str)
        {
            if (str.Length >= 1)
            {
                return str.Substring(0, str.Length - 1);
            }
            return str;
           
        }

        public string Writebogstav(string str)
        {

            KeyboardState keyStart = Keyboard.GetState();



            // small 
            if (keyStart.IsKeyDown(Keys.A) && laststate.IsKeyUp(Keys.A) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str+= "a";
            }
            if (keyStart.IsKeyDown(Keys.B) && laststate.IsKeyUp(Keys.B) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "b";
            }
            if (keyStart.IsKeyDown(Keys.C) && laststate.IsKeyUp(Keys.C) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "c";
            }
            if (keyStart.IsKeyDown(Keys.D) && laststate.IsKeyUp(Keys.D) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "d";
            }
            if (keyStart.IsKeyDown(Keys.E) && laststate.IsKeyUp(Keys.E) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "e";
            }
            if (keyStart.IsKeyDown(Keys.F) && laststate.IsKeyUp(Keys.F) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "f";
            }
            if (keyStart.IsKeyDown(Keys.G) && laststate.IsKeyUp(Keys.G) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
              str += "g";
            }
            if (keyStart.IsKeyDown(Keys.H) && laststate.IsKeyUp(Keys.H) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "h";
            }
            if (keyStart.IsKeyDown(Keys.I) && laststate.IsKeyUp(Keys.I) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "i";
            }
            if (keyStart.IsKeyDown(Keys.J) && laststate.IsKeyUp(Keys.J) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "j";
            }
            if (keyStart.IsKeyDown(Keys.K) && laststate.IsKeyUp(Keys.K) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "k";
            }
            if (keyStart.IsKeyDown(Keys.L) && laststate.IsKeyUp(Keys.L) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str+= "l";
            }
            if (keyStart.IsKeyDown(Keys.M) && laststate.IsKeyUp(Keys.M) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str+= "m";
            }
            if (keyStart.IsKeyDown(Keys.N) && laststate.IsKeyUp(Keys.N) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "n";
            }
            if (keyStart.IsKeyDown(Keys.O) && laststate.IsKeyUp(Keys.O) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "o";
            }
            if (keyStart.IsKeyDown(Keys.P) && laststate.IsKeyUp(Keys.P) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "p";
            }
            if (keyStart.IsKeyDown(Keys.Q) && laststate.IsKeyUp(Keys.Q) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
               str += "q";
            }
            if (keyStart.IsKeyDown(Keys.R) && laststate.IsKeyUp(Keys.R) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "r";
            }
            if (keyStart.IsKeyDown(Keys.S) && laststate.IsKeyUp(Keys.S) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "s";
            }
            if (keyStart.IsKeyDown(Keys.T) && laststate.IsKeyUp(Keys.T) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "t";
            }
            if (keyStart.IsKeyDown(Keys.U) && laststate.IsKeyUp(Keys.U) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "u";
            }
            if (keyStart.IsKeyDown(Keys.V) && laststate.IsKeyUp(Keys.V) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "v";
            }
            if (keyStart.IsKeyDown(Keys.W) && laststate.IsKeyUp(Keys.W) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "w";
            }
            if (keyStart.IsKeyDown(Keys.X) && laststate.IsKeyUp(Keys.X) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "x";
            }
            if (keyStart.IsKeyDown(Keys.Y) && laststate.IsKeyUp(Keys.Y) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "y";
            }
            if (keyStart.IsKeyDown(Keys.Z) && laststate.IsKeyUp(Keys.Z) && !keyStart.IsKeyDown(Keys.LeftShift))
            {
                str += "z";
            }

      /// big 


            if (keyStart.IsKeyDown(Keys.A)&&keyStart.IsKeyDown(Keys.LeftShift) && laststate.IsKeyUp(Keys.A))
            {
                str += "A";
            }
            if (keyStart.IsKeyDown(Keys.B) && keyStart.IsKeyDown(Keys.LeftShift) && laststate.IsKeyUp(Keys.B))
            {
                str += "B";
            }
            if (keyStart.IsKeyDown(Keys.C)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.C))
            {
                str += "C";
            }
            if (keyStart.IsKeyDown(Keys.D)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.D))
            {
                str += "D";
            }
            if (keyStart.IsKeyDown(Keys.E)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.E))
            {
                str += "E";
            }
            if (keyStart.IsKeyDown(Keys.F)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.F))
            {
                str += "F";
            }
            if (keyStart.IsKeyDown(Keys.G)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.G))
            {
                str += "G";
            }
            if (keyStart.IsKeyDown(Keys.H) && keyStart.IsKeyDown(Keys.LeftShift) && laststate.IsKeyUp(Keys.H))
            {
                str += "H";
            }
            if (keyStart.IsKeyDown(Keys.I)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.I))
            {
                str += "I";
            }
            if (keyStart.IsKeyDown(Keys.J)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.J))
            {
                str += "J";
            }
            if (keyStart.IsKeyDown(Keys.K)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.K))
            {
                str += "K";
            }
            if (keyStart.IsKeyDown(Keys.L)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.L))
            {
                str += "L";
            }
            if (keyStart.IsKeyDown(Keys.M)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.M))
            {
                str += "M";
            }
            if (keyStart.IsKeyDown(Keys.N)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.N))
            {
                str += "N";
            }
            if (keyStart.IsKeyDown(Keys.O)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.O))
            {
                str += "O";
            }
            if (keyStart.IsKeyDown(Keys.P)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.P))
            {
                str += "P";
            }
            if (keyStart.IsKeyDown(Keys.Q)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.Q))
            {
                str += "Q";
            }
            if (keyStart.IsKeyDown(Keys.R)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.R))
            {
                str += "R";
            }
            if (keyStart.IsKeyDown(Keys.S)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.S))
            {
                str += "S";
            }
            if (keyStart.IsKeyDown(Keys.T)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.T))
            {
                str += "T";
            }
            if (keyStart.IsKeyDown(Keys.U)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.U))
            {
                str += "U";
            }
            if (keyStart.IsKeyDown(Keys.V)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.V))
            {
                str += "V";
            }
            if (keyStart.IsKeyDown(Keys.W)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.W))
            {
                str += "W";
            }
            if (keyStart.IsKeyDown(Keys.X)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.X))
            {
                str += "X";
            }
            if (keyStart.IsKeyDown(Keys.Y)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.Y))
            {
                str += "Y";
            }
            if (keyStart.IsKeyDown(Keys.Z)&&keyStart.IsKeyDown(Keys.LeftShift)  && laststate.IsKeyUp(Keys.Z))
            {
                str += "Z";
            }
            if (keyStart.IsKeyDown(Keys.Space) && laststate.IsKeyUp(Keys.Space))
            {
                str += " ";
            }

            // remove
            if (keyStart.IsKeyDown(Keys.Back) && laststate.IsKeyUp(Keys.Back))
            {

                str = removeLastChar(Player1);

            }

            laststate = keyStart;

            return str;
        }

        public void Write_name1(GameTime gameTime)
        {      

         Player1 =  Write.Writebogstav(15);
        }

        public void Write_Name2()
        {
         Player2 = Write.Writebogstav(15);
        }
        
        public void Draw(SpriteBatch spriteBatch)
        {
     
            spriteBatch.DrawString(Player1Name, $"Player 1 Name:{Player1 }", new Vector2(150, 200 ), Color.Black);
            spriteBatch.DrawString(Player2Name, $"Player 2 Name:{Player2 }", new Vector2(150, 400), Color.Black);
        }


    }
}
