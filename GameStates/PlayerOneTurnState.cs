using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace DatabaseProjekt.GameState
{
    class PlayerOneTurnState : IState
    {
        public string StateName { get => "PlayerOneTurnState"; }
        private static PlayerOneTurnState instance;

        public static PlayerOneTurnState Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new PlayerOneTurnState();
                }
                return instance;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //draw PlayerOneTurnState
            foreach(GameObject go in GameWorld.playerOneTurnStateGameObjects)
            {
                go.Draw(spriteBatch);
            }
        }

        public void EnterState()
        {
            //logik for det som skal ske før PlayerOneTurnState påbegyndes
        }

        public void ExitState()
        {
            //logik for det som skal ske før afslutning af PlayerOneTurnState
        }

        public void load(ContentManager content)
        {
            throw new NotImplementedException();
        }

        public void Update(GameTime gameTime)
        {
            //update for PlayerOneTurnState
        }
    }
}
