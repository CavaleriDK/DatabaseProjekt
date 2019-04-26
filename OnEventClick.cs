using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DatabaseProjekt
{

  
    class OnEventClick
    {

       public string somthign = "nothing";
       MouseState previousMouseState;
       public OnEventClick()
        {
            previousMouseState = Mouse.GetState();
        }
        public string Click(GameTime game)
        {
            MouseState mouse = Mouse.GetState();

            if (previousMouseState.LeftButton == ButtonState.Released
                     && Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
            }
            else {
                somthign = "nothing";
            }

            previousMouseState = Mouse.GetState();
            
            return somthign;


        }


      
        
    }
  }

