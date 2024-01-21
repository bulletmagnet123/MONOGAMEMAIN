using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using System.Security;

namespace MonoGameMain
{

    public class Game1 : Game
    {
        Texture2D myTexture;
        SpriteBatch spriteBatch;

        GraphicsDeviceManager graphics;
        KeyboardState currentKeyboardState;
        KeyboardState previousKeyboardState;



        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
        }

        protected override void Initialize()
        {
            base.Initialize();
        }
        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            myTexture = Content.Load<Texture2D>("Stuffz/zlol/CaveP");
        }

        protected override void Update(GameTime gameTime)
        {
            // Get the current state of the keyboard
            currentKeyboardState = Keyboard.GetState();

            // Check if the 'A' key is currently pressed and was not pressed in the previous frame
            if (currentKeyboardState.IsKeyDown(Keys.A) && !previousKeyboardState.IsKeyDown(Keys.A))
            {
                Console.WriteLine("A key was pressed");
            }

            // Update the previous keyboard state
            previousKeyboardState = currentKeyboardState;

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // Add your drawing code here

            spriteBatch.Begin();

            spriteBatch.Draw(myTexture, new Vector2(0, 0), Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
