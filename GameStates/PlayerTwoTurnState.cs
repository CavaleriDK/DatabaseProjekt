using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace DatabaseProjekt.GameState
{
    class PlayerTwoTurnState : IState
    {
        private static PlayerTwoTurnState instance;

        public static PlayerTwoTurnState Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new PlayerTwoTurnState();
                }
                return instance;
            }
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            //draw PlayTwoTurnState
        }

        public void EnterState()
        {
            //logik for det som skal ske før PlayerTwoTurnState påbegyndes
        }

        public void ExitState()
        {
            //logik for det som skal ske før afslutning af PlayerTwoTurnState
        }

        public void Update(GameTime gameTime)
        {
            //update for PlayerTwoTurnState
        }
    }
}
