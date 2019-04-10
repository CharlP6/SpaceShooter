using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace SpaceShooter
{
    class Stage
    {
        private ContentManager content;

        private Texture2D background;
        public Texture2D stage_background
        {
            get
            {
                return background;
            }
        }

        public Stage(ContentManager contentManager, string background_path)
        {
            content = contentManager;
            background = content.Load<Texture2D>(background_path);
        }

        public void Initialize()
        {

        }
    }
}
