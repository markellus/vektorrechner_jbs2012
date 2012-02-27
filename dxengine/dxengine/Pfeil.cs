using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace dxengine
{
    class Pfeil
    {
        private Vector3 _startPunkt;
        public Vector3 startPunkt
        {
            get { return _startPunkt; }
            set { _startPunkt = value; }
        }

        private Vector3 _endPunkt;
        public Vector3 endPunkt
        {
            get { return _endPunkt; }
            set { _endPunkt = value; }
        }
    }
}
