using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using DatabaseProjekt.GameObjects;
using DatabaseProjekt.Componets;
namespace DatabaseProjekt.Factorys
{
    public class ObejteFactory : Factory
    {


        private static ObejteFactory instance;

        public static ObejteFactory Insteance
        {
            get
            {
                if ( instance == null)
                {
                    instance = new ObejteFactory();
                }
                return instance;
            }
        }


      




        public override GameObject Create(string type)
        {

            GameObject go = new GameObject();
            switch (type)
            {
                case "Curser":
                   go.addComponet(new Curser());
                   go.addComponet(new SpriteRender(type));
                              
                   break;
                case "StartKnap":
                    go.addComponet(new SpriteRender(type));

                    go.addComponet(new StarteButtone(new Vector2(640, 240)));



                    break;
                case "ExitKnap":
                    go.addComponet(new SpriteRender(type));
                    go.addComponet(new ExitButton(new Vector2(640,460)));
                    break;
                 case "writenameher":
                    go.addComponet(new SpriteRender("writenameher"));
                    go.addComponet(new WriteName1(new Vector2(200, 200)));
                    break;
                case "writenameher2":
                    go.addComponet(new SpriteRender("writenameher"));
                    go.addComponet(new Writename2(new Vector2(200, 400)));
                    break;



                default:
                    break;
            }



            return go;

       
        }

        public override GameObject Create(string type, ContentManager content)
        {


            throw new NotImplementedException();
        }

        public override GameObject Create(string type, Vector2 Position)
        {

            GameObject go = new GameObject();
            switch (type)
            {
                case "Curser":
                    go.addComponet(new Curser());
                    go.addComponet(new SpriteRender(type));


                    break;
                case "StartKnap":
                    go.addComponet(new SpriteRender(type));
                    go.addComponet(new StarteButtone(Position));
                    

                    break;

                default:
                    break;
            }



            return go;

           
        }

        public override GameObject Create(string type, Vector2 Position, ContentManager content)
        {

            GameObject go = new GameObject();
            switch (type)
            {
                case "Curser":
                    go.addComponet(new Curser());
                    go.addComponet(new SpriteRender(type));


                    break;
                case "StartKnap":
                    go.addComponet(new SpriteRender(type));
                    go.addComponet(new StarteButtone());
                 
                    go.LoadContent(content);
                    break;

                default:
                    break;
            }
            return go;
        
        }

        public override GameObject[] Creates(string type)
        {
            throw new NotImplementedException();
        }
    }
}
