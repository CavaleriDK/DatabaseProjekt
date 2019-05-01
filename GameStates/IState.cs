using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
namespace DatabaseProjekt.GameState
{
    public interface IState
    {
        string StateName { get; }
        void EnterState();
        void ExitState();
        void Update(GameTime gameTime);
        void Draw(SpriteBatch spriteBatch);
        void load(ContentManager content);

    }
}
