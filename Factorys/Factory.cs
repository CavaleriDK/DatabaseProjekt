using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace DatabaseProjekt
{
    public abstract class Factory
    {
        public abstract GameObject Create(string type);
        public abstract GameObject Create(string type, ContentManager content);
        public abstract GameObject Create(string type, Vector2 Position);
        public abstract GameObject Create(string type, Vector2 Position, ContentManager content);
        public abstract GameObject[] Creates(string type);
    }
}
