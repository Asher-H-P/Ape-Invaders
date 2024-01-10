using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Ape_Invaders
{
    public class Game1 : Game
    {
        enum Screen
        {
            Intro,
            Story,
            Game,
            Losing,
            Score
        }
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D A;
        Texture2D B;
        Texture2D C;
        Texture2D D;
        Texture2D E;
        Texture2D F;
        Texture2D G;
        Texture2D H;
        Texture2D I;
        Texture2D J;
        Texture2D K;
        Texture2D L;
        Texture2D M;
        Texture2D N;
        Texture2D O;
        Texture2D P;
        Texture2D Q;
        Texture2D R;
        Texture2D S;
        Texture2D T;
        Texture2D U;
        Texture2D V;
        Texture2D W;
        Texture2D X;
        Texture2D Y;
        Texture2D Z;
        Texture2D start2;
        Texture2D score2;
        Texture2D story2;
        Texture2D spikeintro;
        Texture2D ape1;
        Texture2D ape2;
        Texture2D ape3;
        Rectangle play;
        Rectangle story;
        Rectangle score;
        Rectangle spkintro;
        Rectangle apeintro1;
        Rectangle apeintro2;
        Rectangle apeintro3;
        Rectangle select1;
        Rectangle select2;
        Rectangle select3;
        SoundEffect intromsc;
        Screen screen;
        MouseState click;
        KeyboardState clack;
        int msc1 = 0;
        int msc2 = 0;
        int msc3 = 0;
        int select = 1;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 1000;
            _graphics.PreferredBackBufferHeight = 600;
            play = new Rectangle(440, 400, 120, 40);
            story = new Rectangle(440, 460, 120, 40);
            score = new Rectangle(440, 520, 120, 40);
            select1 = new Rectangle(400, 400, 120, 40);
            select2 = new Rectangle(400, 460, 120, 40);
            select3 = new Rectangle(400, 520, 120, 40);
            spkintro = new Rectangle(80, 10, 222, 285);
            apeintro1 = new Rectangle(600, 30, 150, 150);
            apeintro2 = new Rectangle(735, 30, 132, 222);
            apeintro3 = new Rectangle(825, 30, 230, 252);
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            A = Content.Load<Texture2D>("AE-A");
            B = Content.Load<Texture2D>("AE-B");
            C = Content.Load<Texture2D>("AE-C");
            D = Content.Load<Texture2D>("AE-D");
            E = Content.Load<Texture2D>("AE-E");
            F = Content.Load<Texture2D>("AE-F");
            G = Content.Load<Texture2D>("AE-G");
            H = Content.Load<Texture2D>("AE-H");
            I = Content.Load<Texture2D>("AE-I");
            J = Content.Load<Texture2D>("AE-J");
            K = Content.Load<Texture2D>("AE-K");
            L = Content.Load<Texture2D>("AE-L");
            M = Content.Load<Texture2D>("AE-M");
            N = Content.Load<Texture2D>("AE-N");
            O = Content.Load<Texture2D>("AE-O");
            P = Content.Load<Texture2D>("AE-P");
            Q = Content.Load<Texture2D>("AE-Q");
            R = Content.Load<Texture2D>("AE-R");
            S = Content.Load<Texture2D>("AE-S");
            T = Content.Load<Texture2D>("AE-T");
            U = Content.Load<Texture2D>("AE-U");
            V = Content.Load<Texture2D>("AE-V");
            W = Content.Load<Texture2D>("AE-W");
            X = Content.Load<Texture2D>("AE-X");
            Y = Content.Load<Texture2D>("AE-Y");
            Z = Content.Load<Texture2D>("AE-Z");
            start2 = Content.Load<Texture2D>("start");
            score2 = Content.Load<Texture2D>("score");
            story2 = Content.Load<Texture2D>("story");
            spikeintro = Content.Load<Texture2D>("spike_intro");
            ape1 = Content.Load<Texture2D>("ape_intro1");
            ape2 = Content.Load<Texture2D>("ape_intro2");
            ape3 = Content.Load<Texture2D>("ape_intro3");
            intromsc = Content.Load<SoundEffect>("titlescreen");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            click = Mouse.GetState();
            clack = Keyboard.GetState();
            // TODO: Add your update logic here
            if (screen == Screen.Game || screen == Screen.Story || screen == Screen.Score)
            {
                intromsc.Dispose();
            }
            if (clack.IsKeyDown(Keys.Down) && select < 3)
            {
                select = select + 1;
            }
            if (clack.IsKeyDown(Keys.Up) && select > 1)
            {
                select = select - 1;
            }
            if (select == 1 && clack.IsKeyDown(Keys.E))
            {
                screen = Screen.Game;
            }
            else if (select == 2 && clack.IsKeyDown(Keys.E))
            {
                screen = Screen.Story;
            }
            else if (select == 3 && clack.IsKeyDown(Keys.E))
            {
                screen = Screen.Score;
            }
            if (screen == Screen.Losing && clack.IsKeyDown(Keys.Q))
            {
                screen = Screen.Score;
            }
            if (screen == Screen.Story && clack.IsKeyDown(Keys.Q))
            {
                msc1 = 0;
                screen = Screen.Intro;
            }
            if (screen == Screen.Score && clack.IsKeyDown(Keys.Q))
            {
                msc1 = 0;
                screen = Screen.Intro;
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            if (screen == Screen.Intro)
            {
                if (msc1 == 0)
                {
                    intromsc.Play();
                    msc1 = 1;
                }
                _spriteBatch.Draw(A, new Vector2(400, 80), Color.White);
                _spriteBatch.Draw(P, new Vector2(453, 80), Color.White);
                _spriteBatch.Draw(E, new Vector2(515, 80), Color.White);
                _spriteBatch.Draw(I, new Vector2(246, 180), Color.White);
                _spriteBatch.Draw(N, new Vector2(306, 180), Color.White);
                _spriteBatch.Draw(V, new Vector2(366, 180), Color.White);
                _spriteBatch.Draw(A, new Vector2(426, 180), Color.White);
                _spriteBatch.Draw(D, new Vector2(486, 180), Color.White);
                _spriteBatch.Draw(E, new Vector2(546, 180), Color.White);
                _spriteBatch.Draw(R, new Vector2(606, 180), Color.White);
                _spriteBatch.Draw(S, new Vector2(666, 180), Color.White);
                _spriteBatch.Draw(spikeintro, spkintro, Color.White);
                _spriteBatch.Draw(ape1, apeintro1, Color.White);
                _spriteBatch.Draw(ape2, apeintro2, Color.White);
                _spriteBatch.Draw(ape3, apeintro3, Color.White);
                if (select == 1)
                {
                    _spriteBatch.Draw(start2, play, Color.DarkGray);
                }
                else if (select != 1)
                {

                    _spriteBatch.Draw(start2, play, Color.White);
                }
                if (select == 2)
                {
                    _spriteBatch.Draw(story2, story, Color.DarkGray);
                }
                else if (select != 2)
                {

                    _spriteBatch.Draw(story2, story, Color.White);
                }
                if (select == 3)
                {
                    _spriteBatch.Draw(score2, score, Color.DarkGray);
                }
                else if (select != 3)
                {

                    _spriteBatch.Draw(score2, score, Color.White);
                }
                if (screen == Screen.Game || screen == Screen.Story || screen == Screen.Score)
                {
                    intromsc.Dispose();
                }
            }
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}