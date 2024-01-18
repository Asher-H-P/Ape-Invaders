using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Ape_Invaders
{
    internal class Apenum2
    {
        private Texture2D _texture;
        private Vector2 _speed;
        private Rectangle _location;
        public Apenum2(Texture2D texture, int x, int y)
        {
            _texture = texture;
            _location = new Rectangle(x, y, 60, 60);
            _speed = new Vector2();
        }
        public float HSpeed
        {
            get { return _speed.X; }
            set { _speed.X = value; }
        }
        public float VSpeed
        {
            get { return _speed.Y; }
            set { _speed.Y = value; }
        }

        public int Left { get; internal set; }
        public int Right { get; internal set; }

        private void Move()
        {
            _location.X += (int)_speed.X;
            _location.Y += (int)_speed.Y;
        }
        public void Update()
        {
            Move();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _location, Color.White);
        }
        public bool Collide(Rectangle item)
        {
            return _location.Intersects(item);
        }
        public void UndoMove()
        {
            _location.X -= (int)_speed.X;
            _location.Y -= (int)_speed.Y;
        }
    }
}