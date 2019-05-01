using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseProjekt.GameObjects;

namespace DatabaseProjekt.GameState
{
    class MainMenuScreenState : IState
    {
<<<<<<< HEAD

        WirteNames name;

        public static bool AddwriteNames = false;
        public static bool tekst = true;
        private static MainMenuScreenState instance;
        public static MainMenuScreenState Instance
        {
            get
            {
                if( instance== null) {
                    instance = new MainMenuScreenState();
                }
                return instance;
            }
        }
        
        public void Draw(SpriteBatch spritebatch)
        {
<<<<<<< HEAD
        
         
=======



>>>>>>> parent of 59b57df...  mmklpp
            foreach (var go in GameWorld.gameObjects)
            {
                go.Draw(spritebatch);
            }
          
<<<<<<< HEAD
            
=======
>>>>>>> parent of 59b57df...  mmklpp
=======
        public void Draw(SpriteBatch spritebatch)
        {
            //draw MainMenuScreenState
>>>>>>> parent of 94ca0fa... das
        }

        public void EnterState()
        {
<<<<<<< HEAD
            name = new WirteNames();
         
=======
>>>>>>> parent of 94ca0fa... das
            //det som skal ske før MainMenuScreenState påbegyndes
        }

        public void ExitState()
        {
<<<<<<< HEAD
            foreach (var go in GameWorld.gameObjects)
            {
                GameWorld.Remove.Add(go);
            }


            //det som skal ske før MainMenuScreenState afsluttes 
        }

        public void load(ContentManager content)
        {
            GameWorld.gameObjects.Add(ObejteFactory.Insteance.Create("StartKnap",content));
            GameWorld.gameObjects.Add(ObejteFactory.Insteance.Create("ExitKnap",content));
            //GameWorld.gameObjects.Add(ObejteFactory.Insteance.Create("writenameher2", content));
           ///GameWorld.gameObjects.Add(ObejteFactory.Insteance.Create("writenameher", content));


        }

=======
            //det som skal ske før MainMenuScreenState afsluttes 
        }

>>>>>>> parent of 94ca0fa... das
        public void Update(GameTime gameTime)
        {

            if(StarteButtone.Cliket  == true && AddwriteNames == false)
            {
                name.loadContent(GameWorld.GameContent);
                AddwriteNames = true;
            }
          

            //update for MainMenuScreenState
        }
    }
}
