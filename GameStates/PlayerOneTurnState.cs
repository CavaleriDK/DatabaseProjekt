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
        public void Draw(SpriteBatch spriteBatch)
        {
            //draw PlayerOneTurnState
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
