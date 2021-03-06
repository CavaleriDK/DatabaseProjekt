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
    class IntermediateState : IState
    {
        public string StateName { get => "IntermediateState"; } 
        private static IntermediateState instance;

        public static IntermediateState Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new IntermediateState();
                }
                return instance;
            }
        }
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

        public void load(ContentManager content)
        {
            throw new NotImplementedException();
        }

        public void Update(GameTime gameTime)
        {
            //update for IntermediateState
        }
    }
}
