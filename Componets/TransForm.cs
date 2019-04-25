using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DatabaseProjekt.Componets


{
    public class TransForm : Componet
    {
        public Vector2 positon { get; set; }
        public float rotetion { get; set; }
        public float size { get; set; }
        public SpriteEffects s { get; set; }
        public Rectangle rectangle { get; set; }
        /// <summary>
        /// sets positon
        /// </summary>
        /// <param name="Position"></param>
        public TransForm(Vector2 Position)
        {
            this.positon = Position;
            
            rotetion = 0;
            size = 1;

        }
        /// <summary>
        /// sets positon and rotetion
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="Rotetion"></param>
        public TransForm(Vector2 Position, float Rotetion)
        {
            this.positon = Position;
            this.rotetion = Rotetion;
            size = 1;
        }
        /// <summary>
        /// seetter Positon rotetion and size
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="Rotetion"></param>
        /// <param name="Size"></param>
        public TransForm(Vector2 Position, float Rotetion, float Size)
        {
            this.positon = Position;
            this.rotetion = Rotetion;
            this.size = Size;
        }
        /// <summary>
        /// Add a velcity to compnet can brugers til at flytte Componets. 
        /// </summary>
        /// <param name="Velocity"></param>
        public void Translate(Vector2 Velocity)
        {
            positon += Velocity;
        }
    }
}
