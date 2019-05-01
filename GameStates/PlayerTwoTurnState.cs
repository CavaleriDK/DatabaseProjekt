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
    class PlayerTwoTurnState : IState
    {
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

        public void load(ContentManager content)
        {
            throw new NotImplementedException();
        }

        public void Update(GameTime gameTime)
        {
            //update for PlayerTwoTurnState
        }
    }
}
