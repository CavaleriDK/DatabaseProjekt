using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProjekt.GameState
{
    class IntermediateState : IState
    {
        public void Draw(SpriteBatch spriteBatch)
        {
            //draw IntermediateState
        }

        public void EnterState()
        {
            //logik for det som skal ske før IntermediateState påbegyndes
        }

        public void ExitState()
        {
            //logik for det skal skal ske før IntermediateState afsluttes
        }

        public void Update(GameTime gameTime)
        {
            //update for IntermediateState
        }
    }
}
