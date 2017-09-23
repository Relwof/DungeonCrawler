using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace DungeonCrawler
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D banditImage;
        Vector2 banditPosition;




        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
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

            //set the starting position
            //banditPosition = new Vector2(0.0f, 0.0f);

            banditPosition = Vector2.Zero;

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            banditImage = Content.Load<Texture2D>("bandit");

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
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            float time = (float)gameTime.ElapsedGameTime.TotalSeconds;
            float speed = 50.0f;
            float movement = speed * time;

            // TODO: Add your update logic here

            KeyboardState state = Keyboard.GetState();

            if (state.IsKeyDown(Keys.S))
            {

                banditPosition.Y += movement;

            }

            if (state.IsKeyDown(Keys.W))
            {

                banditPosition.Y -= movement;

            }

            if (state.IsKeyDown(Keys.A))
            {

                banditPosition.X -= movement;

            }

            if (state.IsKeyDown(Keys.D))
            {

                banditPosition.X += movement;

            }



            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkBlue);

            // TODO: Add your drawing code here

            //Draw our Sprite

            spriteBatch.Begin();
            spriteBatch.Draw(banditImage, banditPosition, Color.White);
            spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}
