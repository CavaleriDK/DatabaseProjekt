﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;
using DatabaseProjekt.Componets;
using DatabaseProjekt.GameObjects;
using DatabaseProjekt.Factorys;
using System.Data.SQLite;
using DatabaseProjekt.GameState;

namespace DatabaseProjekt
{
    public class GameWorld : Game
    {
        private IState currentState;
        //private static GameWorld instance;
        static GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public static ContentManager GameContent;
        private static SQLiteConnection connection;
        SpriteFont font;
        public static bool ExitGame = false;

<<<<<<< HEAD
=======

<<<<<<< HEAD
=======
        MainMenuScreenState mainMenu;
>>>>>>> parent of 882ed82... fed
        WirteNames wirteNames;
>>>>>>> parent of 94ca0fa... das
        private static GameWorld instance;
        public static GameWorld Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new GameWorld();
                }
                return instance;
            }

        }

        public static bool Cheakbool;
        public  static Vector2 Worldzice;

        //Gem database her maaske?
        const string CONNECTIONSTRING = @"Data Source=camping.db;version=3;New=true;Compress=true";
        public static SQLiteConnection Connection
        {
            get
            {
                if(connection == null)
                {
                    connection = new SQLiteConnection(CONNECTIONSTRING);
                }
                return connection;
            }
        }
        static public  List<GameObject> gameObjects { get; set; } = new List<GameObject>();
        static  public List<GameObject> Remove { get; set; } = new List<GameObject>();
        public List<GameObject> addGameObejts { get; set; } = new List<GameObject>();
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> parent of ddaa792... Revert "lm"
=======
>>>>>>> parent of 9321a0b... revetrer
=======
>>>>>>> parent of 9321a0b... revetrer
        static public List<GameObject> playerOneGameObjects { get; set; } = new List<GameObject>();
        

        /// <summary>
        /// GameWorldInstance
        /// </summary>
        //public static GameWorld Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new GameWorld();
        //        }
        //        return instance;
        //    }
        //}



        /// <summary>
        /// 
        /// </summary>
        public GameWorld()
        {
            //database skal vaere her
            
            Connection.Open();

            Content = Content;
            GameContent = Content;
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;

            Content.RootDirectory = "Content";
        }
        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>'


       
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here'
        
            this.IsMouseVisible = true;

            /// setting world zise to vector2
            Worldzice = new Vector2(GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);

<<<<<<< HEAD
<<<<<<< HEAD
            ChangeState(MainMenuScreenState.Instance);
            
=======
            // adding curser to GameObejtes
          //  curser = ObejteFactory.Insteance.Create("Curser");
          //  gameObjects.Add(ObejteFactory.Insteance.Create("Curser"));
            gameObjects.Add(ObejteFactory.Insteance.Create("StartKnap"));
            
            gameObjects.Add(ObejteFactory.Insteance.Create("StartKnap", new Vector2(400, 200)) );
            gameObjects.Add(ObejteFactory.Insteance.Create("StartKnap", new Vector2(200, 200) ));

        

>>>>>>> parent of 94ca0fa... das
=======

            mainMenu = new MainMenuScreenState();
>>>>>>> parent of 882ed82... fed

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        /// 




        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            font = Content.Load<SpriteFont>("font");
<<<<<<< HEAD
<<<<<<< HEAD
=======


=======
            
>>>>>>> parent of 882ed82... fed

            // adding curser to GameObejtes
            //  curser = ObejteFactory.Insteance.Create("Curser");
            wirteNames.loadContent(Content);
<<<<<<< HEAD
            gameObjects.Add(ObejteFactory.Insteance.Create("Curser"));
            gameObjects.Add(ObejteFactory.Insteance.Create("StartKnap"));
            gameObjects.Add(ObejteFactory.Insteance.Create("ExitKnap"));
            gameObjects.Add(ObejteFactory.Insteance.Create("writenameher"));
            gameObjects.Add(ObejteFactory.Insteance.Create("writenameher2"));
>>>>>>> parent of 94ca0fa... das
=======
            mainMenu.EnterState();
            //gameObjects.Add(ObejteFactory.Insteance.Create("writenameher"));
            //gameObjects.Add(ObejteFactory.Insteance.Create("writenameher2"));
>>>>>>> parent of 882ed82... fed

            //   curser.LoadContent(Content);

            foreach (var go in gameObjects)
            {
                go.LoadContent(Content);
            }


           // startScreen = new StartScreen();
           /// startScreen.LoadStartScreen(Content);
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        /// 
   


        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))

                Exit();
            if (ExitGame) { Quit(); };


            foreach (var go in gameObjects)
            {
                go.Update(gameTime);
            }
            //removing gameObejt
            foreach (var go in Remove)
            {
                gameObjects.Remove(go);
            }
            Remove.Clear();
            ////adding GameObejt
            //foreach (var go in addGameObejts)
            //{
            //    gameObjects.Add(go);
            //}

            //addGameObejts.Clear();



            // TODO: Add your update logic here


            // Update currentState
            //currentState.Update(gameTime);
            // TODO: Add your update logic here
            base.Update(gameTime);
        }


        public void Quit()
        {
            this.Exit();
            
      }
        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here


            spriteBatch.Begin();


          // draws gameObejts 
            //foreach (var go in gameObjects)
            //{
            //    go.Draw(spriteBatch);
            //}

<<<<<<< HEAD
            currentState.Draw(spriteBatch);
          
          //  spriteBatch.DrawString(font, $"mouse Positio check col: {StarteButtone.CLICK} and {ExitButton.CLICK}" , new Vector2(300, 5), Color.Red);           
=======
            foreach (var go in gameObjects)
            {
                go.Draw(spriteBatch);
            }
<<<<<<< HEAD


            spriteBatch.DrawString(font, $"Player Position: check col: {StarteButton.CLICK}", new Vector2(300, 5), Color.Red);

            //currentState.Draw(spriteBatch);

=======
            
>>>>>>> parent of 882ed82... fed
            wirteNames.Draw(spriteBatch);
            spriteBatch.DrawString(font, $"mouse Positio check col: {StarteButtone.CLICK} and {ExitButton.CLICK}" , new Vector2(300, 5), Color.Red);

          

<<<<<<< HEAD
>>>>>>> parent of 94ca0fa... das
=======
            mainMenu.Draw(spriteBatch);
>>>>>>> parent of 882ed82... fed
            spriteBatch.End();

            base.Draw(gameTime);
        }
<<<<<<< HEAD
      
        public static void ChangeState(IState NewState)
=======
        public void ChangeState(IState NewState)
>>>>>>> parent of 59b57df...  mmklpp
        {
            if(currentState != null)
            {
                currentState.ExitState();
            }
            currentState = NewState;
<<<<<<< HEAD
            NewState.EnterState();                 
=======
            NewState.EnterState();

>>>>>>> parent of 882ed82... fed
        }

    }
}
