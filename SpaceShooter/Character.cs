using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SpaceShooter
{
    class Character
    {
        public int health { get; set; }

        public Point position { get; set; }
        public Vector2 facing_direction { get; set; }
        public float speed { get; set; }

        public Character(int _health, Point _position, Vector2 _facing, float _speed)
        {
            health = _health;
            position = _position;
            facing_direction = _facing;
            speed = _speed;
        }

        public virtual void update()
        {

        }

        public virtual void draw()
        {

        }

    }
}
