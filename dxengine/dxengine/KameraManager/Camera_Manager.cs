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
    public class Camera_Manager : Microsoft.Xna.Framework.GameComponent
    {
        private Dictionary<string, QatCamera> m_tblCameras = new Dictionary<string, QatCamera>();
        private QatCamera m_cameraActive;

        public Camera_Manager(Game game)
            : base(game)
        {
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public void Initialize(Viewport newViewport)
        {
            QatCamera cameraDefault = new QatCamera(newViewport);
            this["default"] = cameraDefault;
            ActiveCamera = cameraDefault;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
        
        public void UpdateViewports(Viewport newViewport)
        {
            foreach (QatCamera cam in m_tblCameras.Values)
                cam.Viewport = newViewport;
        }

        public void SetActiveCamera(string strName)
        {
            if (m_tblCameras.ContainsKey(strName))
                m_cameraActive = this[strName];
        }

        public QatCamera ActiveCamera
        {
            get
            {
                return m_cameraActive;
            }
            set
            {
                m_cameraActive = value;
            }
        }

        public QatCamera this[string strKey]
        {
            get
            {
                if (m_tblCameras.ContainsKey(strKey))
                    return m_tblCameras[strKey];
                else
                    return null;
            }

            set
            {
                if (m_tblCameras.ContainsKey(strKey) == false)
                    m_tblCameras.Add(strKey, value);
                else
                    m_tblCameras[strKey] = value;
            }
        }
    }
}