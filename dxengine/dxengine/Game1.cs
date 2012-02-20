using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace dxengine
{

    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public static Camera_Manager CameraManager;
        public static Input_Manager InputManager;

        public ModelItem test;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            CameraManager = new Camera_Manager(this);
            Components.Add(CameraManager);
            InputManager = new Input_Manager(this);
            Components.Add(InputManager);
            CameraManager.Initialize(GraphicsDevice.Viewport);
            this.IsMouseVisible = true;
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            test = new ModelItem(Content.Load<Model>("Objekte/Erde"));
            test.location = new Vector3(-50, -50, -50);
        }

        protected override void UnloadContent()
        {
        }

        protected override void Update(GameTime gameTime)
        {
            CameraManager.ActiveCamera.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();
            GraphicsDevice.Clear(Color.CornflowerBlue);
            test.Draw(CameraManager);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
