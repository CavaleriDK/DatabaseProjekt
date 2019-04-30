using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DatabaseProjekt.GameState
{
    class PlayerOneTurnState : IState
    {
        private static PlayerOneTurnState insPlayerOne;

        public static PlayerOneTurnState InsPlayerOne
        {
            get
            {
                if(insPlayerOne == null)
                {
                    insPlayerOne = new PlayerOneTurnState();
                }
                return insPlayerOne;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            //draw PlayerOneTurnState
            foreach(GameObject go in GameWorld.playerOneGameObjects)
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

        public void Update(GameTime gameTime)
        {
            //update for PlayerOneTurnState
        }
    }
}
