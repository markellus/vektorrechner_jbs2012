#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
#endregion

namespace dxengine
{

    public class ModelItem
    {
        private Model m_model;
        private Vector3 m_vecModelLoc = new Vector3(0, 0, -10);
        private Quaternion m_quatModelRotation = new Quaternion(0, 0, 0, 1);
        private Vector3 m_vecModelVelocity = Vector3.Zero;

        public ModelItem(Model model)
        {
            m_model = model;
        }

        public ModelItem()
        {
        }

        public void Update()
        {
            //add velocity to current position
            m_vecModelLoc += m_vecModelVelocity;

            //bleed off velocity over time
            m_vecModelVelocity *= 0.95f;
        }
        public void Draw(Camera_Manager m_CameraManager)
        {
            Matrix[] transforms;
            int v, h;

            //Move & rotate the model itself as a whole
            m_model.Root.Transform = Matrix.CreateFromQuaternion(m_quatModelRotation) *
                Matrix.CreateTranslation(m_vecModelLoc);

            //Draw the model, a model can have multiple meshes, so loop
            //We're using CopyAbsoluteBoneTransformsTo so that we retain relative positioning of meshes
            //in the model.
            transforms = new Matrix[m_model.Bones.Count];
            m_model.CopyAbsoluteBoneTransformsTo(transforms);
            for (h = 0; h < m_model.Meshes.Count; h++)
            {
                ModelMesh mesh = m_model.Meshes[h];
                //This is where the mesh orientation is set, as well as our camera and projection
                for (v = 0; v < mesh.Effects.Count; v++)
                {
                    BasicEffect effect = (BasicEffect)mesh.Effects[v];
                    effect.EnableDefaultLighting();
                    effect.World = transforms[mesh.ParentBone.Index];
                    effect.View = m_CameraManager.ActiveCamera.View;
                    effect.Projection = m_CameraManager.ActiveCamera.Projection;
                }

                //Draw the mesh, will use the effects set above.
                mesh.Draw();
            }
        }


        #region Model rotations
        //Quaternions I don't yet understand but apparently they help avoid "gimble lock" when rotating a 3D model.
        //So, we'll use one to rotate the spaceship.
        public void Yaw(float fDegrees)
        {
            rotate(new Vector3(0, 1, 0), fDegrees);
        }

        public void Roll(float fDegrees)
        {
            rotate(new Vector3(0, 0, 1), fDegrees);
        }

        public void Pitch(float fDegrees)
        {
            rotate(new Vector3(1, 0, 0), fDegrees);
        }

        private Quaternion rotateModel(Vector3 axis, float fDegrees, Quaternion quatRotation)
        {
            //Don't know why we need to transform the vector
            axis = Vector3.Transform(axis, Matrix.CreateFromQuaternion(quatRotation));

            //Why do we normalize?
            quatRotation = Quaternion.Normalize(Quaternion.CreateFromAxisAngle(axis, MathHelper.ToRadians(fDegrees)) *
                quatRotation);

            return quatRotation;
        }

        private void rotate(Vector3 axis, float fDegrees)
        {
            //Don't know why we need to transform the vector
            axis = Vector3.Transform(axis, Matrix.CreateFromQuaternion(m_quatModelRotation));

            //Why do we normalize?
            m_quatModelRotation = Quaternion.Normalize(Quaternion.CreateFromAxisAngle(axis, MathHelper.ToRadians(fDegrees)) *
                m_quatModelRotation);
        }
        #endregion

        #region Properties
        public Model model
        {
            get { return m_model; }
            set { m_model = value; }
        }
        public Vector3 location
        {
            get { return m_vecModelLoc; }
            set { m_vecModelLoc = value; }
        }
        public Quaternion rotation
        {
            get { return m_quatModelRotation; }
            set { m_quatModelRotation = value; }
        }
        public Vector3 velocity
        {
            get { return m_vecModelVelocity; }
            set { m_vecModelVelocity = value; }
        }
        #endregion
    }


}
