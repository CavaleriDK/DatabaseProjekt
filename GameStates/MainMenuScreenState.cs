using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseProjekt.GameObjects;
using DatabaseProjekt.Factorys;
using Microsoft.Xna.Framework.Content;

namespace DatabaseProjekt.GameState
{
    class MainMenuScreenState : IState
    {



        WirteNames name;

        public bool AddwriteNames = false;
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
            foreach (var go in GameWorld.gameObjects)
            {
                go.Draw(spritebatch);
            }        
        }



        public void EnterState()
        {
            name = new WirteNames();
            // GameWorld.gameObjects.Add(ObejteFactory.Insteance.Create("Curser"));

            //det som skal ske før MainMenuScreenState påbegyndes
        }

        public void ExitState()
        {

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
           
        }

        public void Update(GameTime gameTime)
        {
            if (StarteButtone.Cliket == true &&  AddwriteNames == false)
            {
                name.loadContent(GameWorld.GameContent);
       
            }
            //update for MainMenuScreenState
        }
    }
}
