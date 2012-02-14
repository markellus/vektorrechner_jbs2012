
#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
#endregion

namespace dxengine
{

    public partial class MatCamera : Microsoft.Xna.Framework.GameComponent
    {
        #region Specific Fields and Properties for this Component
        private float fieldOfView = MathHelper.PiOver4;             // 45 degree Field of View
        private float aspectRatio = 4.0f / 3.0f;                    // "normal" aspect ratio
        private float zNearPlane = 0.1f;                            // near clipping plane
        private float zFarPlane = 1000.0f;                          // far clipping plane

        private Vector3 worldScale = new Vector3(100.0f, 100.0f, 100.0f);
        private Vector3 worldTranslation = Vector3.Zero;
        private Vector3 worldRotation = Vector3.Zero;

        Vector3 cameraReference = new Vector3(0, 0, 10);
        private Vector3 cameraUpVector = new Vector3(0.0f, 1.0f, 0.0f);     // +Y is up, +Z is into screen.   
        private Vector3 cameraOrientation = new Vector3(0.0f, 0.0f, 0.0f);  // yaw, pitch, roll
        private Vector3 cameraPosition = new Vector3(0.0f, 0.0f, 0.0f);     // x, y, z

        private string currentCameraPosition;
        private string currentCameraOrientation;
        private string currentCameraZoom;
        private Matrix view;
        /// <summary>
        /// The viewing matrix.
        /// </summary>
        public Matrix View
        {
            get { return view; }
        }

        private Matrix proj;
        /// <summary>
        /// The projection matrix.
        /// </summary>
        public Matrix Proj
        {
            get { return proj; }
        }

        private Matrix world;
        /// <summary>
        /// The world matrix. (The orientation of the world.)
        /// </summary>
        public Matrix World
        {
            get { return world; }
        }

        private Matrix worldviewproj;
        /// <summary>
        /// The world-view-projection matrix that will be used by shaders.
        /// </summary>
        public Matrix WorldViewProj
        {
            get { return worldviewproj; }
        }
        #endregion

        public MatCamera(Game game)
            : base(game)
        {
        }

        public override void Initialize()
        {
            // Create the World Matrix
            this.world = Matrix.CreateScale(this.worldScale);
            //* Matrix.CreateTranslation(this.worldTranslation)
            //* Matrix.CreateRotationX(this.worldRotation.X)
            //* Matrix.CreateRotationY(this.worldRotation.Y)
            //* Matrix.CreateRotationZ(this.worldRotation.Z);
            // Create the Projection Matrix
            this.proj = Matrix.CreatePerspective(this.fieldOfView, this.aspectRatio, this.zNearPlane, this.zFarPlane);
            // Create the View Matrix.  We start looking straight ahead.
            this.view = Matrix.CreateTranslation(this.cameraPosition);
            //this.view = Matrix.CreateLookAt(this.cameraPosition, this.cameraTarget, this.cameraUpVector);
            // Create the WorldViewProj Matrix
            this.worldviewproj = this.world * this.view * this.proj;

            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            UpdateCameraPosition();
            UpdateCameraOrientation();
            UpdateCameraFieldOfView();
            //this.view = Matrix.CreateTranslation(this.cameraPosition)
            //          * Matrix.CreateRotationX(this.cameraOrientation.X)
            //          * Matrix.CreateRotationY(this.cameraOrientation.Y)
            //          * Matrix.CreateRotationZ(this.cameraOrientation.Z);
            //this.view = Matrix.CreateLookAt(this.cameraPosition, this.cameraTarget, this.cameraUpVector);
            this.worldviewproj = this.world * this.view * this.proj;

            base.Update(gameTime);
        }

        private void UpdateCameraPosition()
        {
            float deltaX = 0.0f;
            float deltaY = 0.0f;
            float deltaZ = 0.0f;

            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.W))     // forward
            {
                deltaZ = 1.0f;
            }
            if (keyboardState.IsKeyDown(Keys.S))    // backward
            {
                deltaZ = -1.0f;
            }
            if (keyboardState.IsKeyDown(Keys.A))    // left
            {
                deltaX = -1.0f;
            }
            if (keyboardState.IsKeyDown(Keys.D))    // right
            {
                deltaX = 1.0f;
            }
            if (keyboardState.IsKeyDown(Keys.Q))    // up
            {
                deltaY = 1.0f;
            }
            if (keyboardState.IsKeyDown(Keys.Z))    // down
            {
                deltaY = -1.0f;
            }
            if (keyboardState.IsKeyDown(Keys.X))    // reset view position
            {
                this.cameraPosition = new Vector3(0.0f, 0.0f, 0.0f);
                this.currentCameraPosition = String.Format("X= {0:#0.0} Y= {1:#0.0} Z= {2:#0.0}", this.cameraPosition.X, this.cameraPosition.Y, this.cameraPosition.Z);
            }
            Vector3 translation = new Vector3(deltaX, deltaY, deltaZ);
            this.cameraPosition += translation;

            this.currentCameraPosition = String.Format("X= {0:#0.0} Y= {1:#0.0} Z= {2:#0.0}", this.cameraPosition.X, this.cameraPosition.Y, this.cameraPosition.Z);
        }

        private void UpdateCameraOrientation()
        {
            float deltaYaw = 0.0f;      // about Y-axis
            float deltaPitch = 0.0f;    // about X-axis
            float deltaRoll = 0.0f;     // about Z-axis

            //float rate = MathHelper.Pi / 180.0f;    // rate is 1 unit = 1 degree.
            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.NumPad6))
            {
                deltaYaw = 1.0f;
            }
            if (keyboardState.IsKeyDown(Keys.NumPad4))
            {
                deltaYaw = -1.0f;
            }
            if (keyboardState.IsKeyDown(Keys.NumPad2))
            {
                deltaPitch = -1.0f;
            }
            if (keyboardState.IsKeyDown(Keys.NumPad8))
            {
                deltaPitch = 1.0f;
            }
            if (keyboardState.IsKeyDown(Keys.NumPad9))
            {
                deltaRoll = 1.0f;
            }
            if (keyboardState.IsKeyDown(Keys.NumPad3))
            {
                deltaRoll = -1.0f;
            }
            if (keyboardState.IsKeyDown(Keys.NumPad5))  // Reset View Orientation...
            {
                this.cameraOrientation = new Vector3(0.0f, 0.0f, 0.0f);
                this.currentCameraOrientation = String.Format("Yaw= {0:#0.0} Pitch= {1:#0.0} Roll= {2:#0.0}", (this.cameraOrientation.X * 180.0 / MathHelper.Pi), (this.cameraOrientation.Y * 180.0 / MathHelper.Pi), (this.cameraOrientation.Z * 180.0 / MathHelper.Pi));
                return;
            }
            //Vector3 rotation = new Vector3(deltaPitch * rate, deltaYaw * rate, deltaRoll * rate);
            //this.cameraOrientation += rotation;

            //this.currentCameraOrientation = String.Format("Pitch= {0:#0.0} Yaw= {1:#0.0} Roll= {2:#0.0}", (this.cameraOrientation.X * 180.0 / MathHelper.Pi), (this.cameraOrientation.Y * 180.0 / MathHelper.Pi), (this.cameraOrientation.Z * 180.0 / MathHelper.Pi));
            Matrix rotationMatrix = Matrix.CreateRotationX(deltaPitch) * Matrix.CreateRotationY(deltaYaw) * Matrix.CreateRotationZ(deltaRoll);

            // Create a vector pointing the direction the camera is facing.
            Vector3 transformedReference = Vector3.Transform(cameraReference, rotationMatrix);

            // Calculate the position the camera is looking at.
            Vector3 cameraLookat = cameraPosition + transformedReference;

            // Set up view matrix and projection matrix.
            view = Matrix.CreateLookAt(cameraPosition, cameraLookat, new Vector3(0.0f, 1.0f, 0.0f));

            //proj = Matrix.CreatePerspectiveFieldOfView(fieldOfView, aspectRatio, zNearPlane, zFarPlane);
        }

        private void UpdateCameraFieldOfView()
        {
            float deltaZoom = 0.0f;
            float rate = MathHelper.Pi * 180.0f;    // rate is 1 unit = 1 degree.
            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.R))
            {
                deltaZoom = 1.0f;
            }
            if (keyboardState.IsKeyDown(Keys.F))
            {
                deltaZoom = -1.0f;
            }
            if (keyboardState.IsKeyDown(Keys.V))  // Reset Projection FOV...
            {
                this.fieldOfView = MathHelper.PiOver4;
                this.proj = Matrix.CreatePerspective(this.fieldOfView, this.aspectRatio, this.zNearPlane, this.zFarPlane);
                this.currentCameraZoom = String.Format("FOV= {0:#0.0}", (this.fieldOfView * 180.0 / MathHelper.Pi));
                return;
            }
            this.fieldOfView += deltaZoom / rate;
            this.proj = Matrix.CreatePerspective(this.fieldOfView, this.aspectRatio, this.zNearPlane, this.zFarPlane);
            this.currentCameraZoom = String.Format("FOV= {0:#0.0}", (this.fieldOfView * 180.0 / MathHelper.Pi));
        }

    }
}


