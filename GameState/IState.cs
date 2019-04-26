using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProjekt.GameState
{
    interface IState
    {
        void EnterState();
        void ExitState();
        void Update(GameTime gameTime);
        void Draw(SpriteBatch spriteBatch);

    }
}
