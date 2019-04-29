using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using DatabaseProjekt.Componets;
using DatabaseProjekt.GameObjects;
using DatabaseProjekt.Factorys;
using DatabaseProjekt.GameState;

namespace DatabaseProjekt
{
    public class GameWorld : Game
    {
        private IState currentState;
        //private static GameWorld instance;
        static GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont font;

        public static bool Cheakbool;
        public  static Vector2 Worldzice;

      
        static public  List<GameObject> gameObjects { get; set; } = new List<GameObject>();
      public List<GameObject> Remove { get; set; } = new List<GameObject>();
        public List<GameObject> addGameObejts { get; set; } = new List<GameObject>();



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

            Content = Content;
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
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here'
            
            this.IsMouseVisible = true;
            /// setting world zise to vector2
            Worldzice = new Vector2(GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);

            // adding curser to GameObejtes
          //  curser = ObejteFactory.Insteance.Create("Curser");
            gameObjects.Add(ObejteFactory.Insteance.Create("Curser"));
            gameObjects.Add(ObejteFactory.Insteance.Create("StartKnap"));
                
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

            
        MouseState mouseState;
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

         
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
            //adding GameObejt
            foreach (var go in addGameObejts)
            {
                gameObjects.Add(go);
            }

            addGameObejts.Clear();


            // Update currentState
            //currentState.Update(gameTime);
            // TODO: Add your update logic here
            base.Update(gameTime);
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


            //draws gameObejts
            foreach (var go in gameObjects)
            {
                go.Draw(spriteBatch);
            }

            spriteBatch.DrawString(font, $"Player Position: check col: {StarteButton.CLICK}", new Vector2(300, 5), Color.Red);


            //currentState.Draw(spriteBatch);
            spriteBatch.End();

            base.Draw(gameTime);
        }
        public void ChangeState(IState NewState)
        {
            if(currentState != null)
            {
                currentState.ExitState();
            }

            currentState = NewState;
            NewState.EnterState();

        }

    }
}
