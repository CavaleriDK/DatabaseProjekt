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

namespace DatabaseProjekt
{
    public class GameObject
    {
        private List<Componet> Componets = new List<Componet>();
        public TransForm transForm { get; set; }
      
        /// <summary>
        /// gives gameObjet a transgfrom
        /// </summary>
        public GameObject()
        {
            transForm = new TransForm(Vector2.Zero);

            addComponet(transForm);
        }
        /// <summary>
        /// addComponets to Componts
        /// </summary>
        public void addComponet(Componet componet)
        {
            componet.Attach(this);
            Componets.Add(componet);
        }


        public void RemoveComponet(Componet componet)
        {
            Componets.Remove(componet);
        }

        /// <summary>
        /// loaderContent
        /// </summary>
        /// <param name="content"></param>
        public void LoadContent(ContentManager content)
        {
            foreach (var co in Componets)
            {
                co.LoadContent(content);
            }
        }
        /// <summary>
        /// Updating Compoent
        /// </summary>
        /// <param name="gameTime"></param>
        public void Update(GameTime gameTime)
        {
            foreach (var co in Componets)
            {
                co.Update(gameTime);
            }
        }
        /// <summary>
        /// Draws Compontes
        /// </summary>
        /// <param name="spriteBatch"></param>
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (var co in Componets)
            {
                co.Draw(spriteBatch);
            }
        }
        /// <summary>
        /// Finds Component
        /// </summary>
        public Componet FindCompent(string Componet)
        {
            return Componets.Find(x => x.GetType().Name == Componet);

        }
    }
}
