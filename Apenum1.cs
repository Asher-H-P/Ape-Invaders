using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Ape_Invaders
{
    internal class Apenum1
    {
        private Texture2D _texture1;
        private Vector2 _speed1;
        private Rectangle _location1;
        public Apenum1(Texture2D texture, int x, int y)
        {
            _texture1 = texture;
            _location1 = new Rectangle(x, y, 50, 50);
            _speed1 = new Vector2();
        }
        public float HSpeed1
        {
            get { return _speed1.X; }
            set { _speed1.X = value; }
        }
        public float VSpeed1
        {
            get { return _speed1.Y; }
            set { _speed1.Y = value; }
        }

        public int Left { get; internal set; }
        public int Right { get; internal set; }

        private void Move()
        {
            _location1.X += (int)_speed1.X;
            _location1.Y += (int)_speed1.Y;
        }
        public void Update()
        {
            Move();
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture1, _location1, Color.White);
        }
        public bool Collide(Rectangle item)
        {
            return _location1.Intersects(item);
        }
        public void UndoMove()
        {
            _location1.X -= (int)_speed1.X;
            _location1.Y -= (int)_speed1.Y;
        }
    }
}
