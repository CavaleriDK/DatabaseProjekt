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


        public string StateName { get => "MainMenuScreenState"; }

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
           
         // GameWorld.gameObjects.Add(ObejteFactory.Insteance.Create("Curser"));
         
            //det som skal ske før MainMenuScreenState påbegyndes
        }

        public void ExitState()
        {

          
         
            //det som skal ske før MainMenuScreenState afsluttes 
        }

        public void load(ContentManager content)
        {
            GameWorld.gameObjects.Add(ObejteFactory.Insteance.Create("StartKnap",content));
            GameWorld.gameObjects.Add(ObejteFactory.Insteance.Create("ExitKnap",content));
           
        }

        public void Update(GameTime gameTime)
        {
            //update for MainMenuScreenState
        }
    }
}
