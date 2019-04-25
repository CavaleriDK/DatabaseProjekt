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
        public GameObject curser;
        public void LoadStartScreen(ContentManager content)
        {
            Button = new GameObject();
            curser = new GameObject();


            //Button.addComponet(new StarteButton());
            //Button.addComponet(new SpriteRender("StartKnap"));
            //Button.addComponet(new Colider());
            //Button.LoadContent(content);

            //curser.addComponet(new Curser());
            //curser.addComponet(new SpriteRender("Curser"));
            //curser.addComponet(new Coliders());
            //curser.LoadContent(content);

          
        }

        public void drawStartScreen(GameTime gameTime, SpriteBatch spriteBatch)
        {
            //curser.Draw(spriteBatch);
            Button.Draw(spriteBatch);
            
        }

        public void Updata(GameTime gameTime)
        {
            curser.Update(gameTime);
            //Button.Update(gameTime);
        }



        

    }
}
