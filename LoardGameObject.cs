using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using DatabaseProjekt.Componets;
using DatabaseProjekt.GameObjects;
namespace DatabaseProjekt
{
    class StartScreen
    {

        public GameObject Button;

        public void LoadStartScreen(ContentManager content)
        {
            Button = new GameObject();
            


            Button.addComponet(new Button(new Vector2(300, 300)));
            Button.addComponet(new SpriteRender("StartKnap"));
            Button.addComponet(new Coliders());
            Button.LoadContent(content);    
            



        }

        public void drawStartScreen(GameTime gameTime,SpriteBatch spriteBatch)
        {

            Button.Draw(spriteBatch);
            
        }
        
    }
}
