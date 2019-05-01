﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProjekt.GameState
{
    class WinGameState : IState
    {
        public string StateName { get => "WinGameState"; }
        public void Draw(SpriteBatch spriteBatch)
        {
            //draw WinGameState
        }

        public void EnterState()
        {
            //det som skal ske før WinGameState påbegyndes
        }

        public void ExitState()
        {
            //det som skal ske før WinGameState afsluttes
        }

        public void load(ContentManager content)
        {
            throw new NotImplementedException();
        }

        public void Update(GameTime gameTime)
        {
            //update for WinGameState
        }
    }
}
