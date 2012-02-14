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
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;


namespace dxengine
{

    public class Input_Manager : Microsoft.Xna.Framework.GameComponent
    {
        private int m_nMouseX;
        private int m_nMouseY;
        
        public Input_Manager(Game game)
            : base(game)
        {
        }

        public override void Initialize()
        {
           base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            UpdateInput();
            base.Update(gameTime);
        }

        protected void UpdateMouse(KeyboardState kybState)
        {
            MouseState msCurrent = Mouse.GetState();
            float Speed = 0.5f;
            if (m_nMouseX == 0 && m_nMouseY == 0)
            {
                m_nMouseY = msCurrent.Y;
                m_nMouseX = msCurrent.X;
                return;
            }

            if (msCurrent.RightButton == ButtonState.Pressed)
            {

                if (m_nMouseX < msCurrent.X)
                {
                    if (kybState.IsKeyUp(Keys.LeftShift))
                        Game1.CameraManager.ActiveCamera.RotateY(Speed * 2);
                    else
                        Game1.CameraManager.ActiveCamera.MoveX(Speed);
                }

                else if (m_nMouseX > msCurrent.X)
                {
                    if (kybState.IsKeyUp(Keys.LeftShift))
                        Game1.CameraManager.ActiveCamera.RotateY(-Speed * 2);
                    else
                        Game1.CameraManager.ActiveCamera.MoveX(-Speed);
                }


                if (m_nMouseY < msCurrent.Y)
                {
                    if (kybState.IsKeyUp(Keys.LeftShift))
                        Game1.CameraManager.ActiveCamera.RotateX(Speed * 2);
                    else
                        Game1.CameraManager.ActiveCamera.MoveY(Speed);
                }

                else if (m_nMouseY > msCurrent.Y)
                {
                    if (kybState.IsKeyUp(Keys.LeftShift))
                        Game1.CameraManager.ActiveCamera.RotateX(-Speed * 2);
                    else
                        Game1.CameraManager.ActiveCamera.MoveY(-Speed);
                }

            }

            m_nMouseX = msCurrent.X;
            m_nMouseY = msCurrent.Y;
        }

        protected void UpdateInput()
        {
            KeyboardState kybState = Keyboard.GetState();

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || kybState.IsKeyDown(Keys.Escape))
                 Game.Exit();

            Keys[] keysPressed = kybState.GetPressedKeys();
            Vector3 vecDeltaV = Vector3.Zero;
            int i;

            UpdateMouse(kybState);

            for (i = 0; i < keysPressed.Length; i++)
            {
                Keys keyPressed = keysPressed[i];
                switch (keyPressed)
                {
                    #region Model positioning
                    //case Keys.Left:
                    //    vecDeltaV.X = -0.1f;
                    //    Game1.m_models[0].velocity += vecDeltaV;
                    //    break;

                    //case Keys.Right:
                    //    vecDeltaV.X = 0.1f;
                    //    Game1.m_models[0].velocity += vecDeltaV;
                    //    break;

                    //case Keys.Up:
                    //    vecDeltaV.Y = 0.1f;
                    //    Game1.m_models[0].velocity += vecDeltaV;
                    //    break;

                    //case Keys.Down:
                    //    vecDeltaV.Y = -0.1f;
                    //    Game1.m_models[0].velocity += vecDeltaV;
                    //    break;

                    //case Keys.Space:
                    //    vecDeltaV.Z = -0.1f;
                    //    Game1.m_models[0].velocity += vecDeltaV;
                    //    break;


                    #endregion

                    #region Model rotations
                    ////model 1
                    //case Keys.A:
                    //    Game1.m_models[0].Yaw(-1f);
                    //    break;

                    //case Keys.D:
                    //    Game1.m_models[0].Yaw(1f);
                    //    break;

                    //case Keys.W:
                    //    Game1.m_models[0].Pitch(-1f);
                    //    break;

                    //case Keys.S:
                    //    Game1.m_models[0].Pitch(1f);
                    //    break;

                    //case Keys.E:
                    //    Game1.m_models[0].Roll(1f);
                    //    break;

                    //case Keys.Q:
                    //    Game1.m_models[0].Roll(-1f);
                    //    break;

                    ////model 2
                    //case Keys.F:
                    //    Game1.m_models[1].Yaw(-1f);
                    //    break;

                    //case Keys.H:
                    //    Game1.m_models[1].Yaw(1f);
                    //    break;

                    //case Keys.T:
                    //    Game1.m_models[1].Pitch(-1f);
                    //    break;

                    //case Keys.G:
                    //    Game1.m_models[1].Pitch(1f);
                    //    break;

                    //case Keys.Y:
                    //    Game1.m_models[1].Roll(1f);
                    //    break;

                    //case Keys.R:
                    //    Game1.m_models[1].Roll(-1f);
                    //    break;
                    #endregion

                    #region Camera rotation & panning
                    case Keys.M:
                        Game1.CameraManager.ActiveCamera.Position = new Vector3(2000, 100, 2000);
                        break;

                    case Keys.W:

                                Game1.CameraManager.ActiveCamera.RotateX(-1f);
                        break;

                    case Keys.S:
                                Game1.CameraManager.ActiveCamera.RotateX(1f);
                        break;

                    case Keys.D:

                                Game1.CameraManager.ActiveCamera.RotateY(1f);
                        break;

                    case Keys.A:

                                Game1.CameraManager.ActiveCamera.RotateY(-1f);
                        break;

                    case Keys.Q:

                                Game1.CameraManager.ActiveCamera.RotateZ(1f);
                        break;

                    case Keys.E:

                                Game1.CameraManager.ActiveCamera.RotateZ(-1f);
                        break;

                    case Keys.Up:
                        Game1.CameraManager.ActiveCamera.MoveZ(1f);
                        break;
                    case Keys.Down:
                        Game1.CameraManager.ActiveCamera.MoveZ(-1f);
                        break;
                    case Keys.Left:
                        Game1.CameraManager.ActiveCamera.MoveX(1f);
                        break;
                    case Keys.Right:
                        Game1.CameraManager.ActiveCamera.MoveX(-1f);
                        break;

                    #endregion

                    #region Game controls

                    case Keys.F5:
                        
                        break;

                    //case Keys.P:
                    //    break;

                    //case Keys.F9:
                    //case Keys.NumPad5:
                    //    Game1.m_models[0].rotation = new Quaternion(0, 0, 0, 1);
                    //    Game1.m_models[0].location = new Vector3(-10, 0, -10);
                    //    Game1.m_models[0].velocity = Vector3.Zero;
                    //    Game1.m_models[1].rotation = new Quaternion(0, 0, 0, 1);
                    //    Game1.m_models[1].location = new Vector3(10, 0, -10);
                    //    Game1.m_models[1].velocity = Vector3.Zero;
                    //    Game1.m_CameraManager.ActiveCamera.ZeroRotations();
                    //    Game1.m_CameraManager.ActiveCamera.ReturnToOrigin();
                    //    break;

                    //case Keys.F1:
                    //    Game1.LockedTarget = 0;
                    //    break;
                    //case Keys.F2:
                    //    Game1.LockedTarget = 1;
                    //    break;
                    //case Keys.F5:
                    //    Game1.LockedTarget = -1;
                    //    break;

                    #endregion
                }
            }

        }

    }
}