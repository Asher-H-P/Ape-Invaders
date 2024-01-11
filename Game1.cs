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
        SoundEffect scoremsc;
        SoundEffect storymsc;
        SoundEffect gamemsc;
        Screen screen;
        MouseState click;
        KeyboardState clack;
        private SpriteFont storytext;
        int msc1 = 0;
        int msc2 = 0;
        int msc3 = 0;
        int msc4 = 0;
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
            scoremsc = Content.Load<SoundEffect>("scoremsc");
            storymsc = Content.Load<SoundEffect>("storymsc");
            gamemsc = Content.Load<SoundEffect>("storymsc");
            storytext = Content.Load<SpriteFont>("text1");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            click = Mouse.GetState();
            clack = Keyboard.GetState();
            // TODO: Add your update logic here
            if (screen != Screen.Intro)
            {
                intromsc.Dispose();
            }
            if (screen != Screen.Game)
            {
                gamemsc.Dispose();
            }
            if (screen != Screen.Story)
            {
                storymsc.Dispose();
            }
            if (screen != Screen.Score)
            {
                scoremsc.Dispose();
            }
            if (clack.IsKeyDown(Keys.Down) && select < 30)
            {
                select = select + 1;
            }
            if (clack.IsKeyDown(Keys.Up) && select > 1)
            {
                select = select - 1;
            }
            if (select >= 1 && select <= 10 && clack.IsKeyDown(Keys.E))
            {

                screen = Screen.Game;
            }
            //music
            else if (select >= 11 && select <= 20 && clack.IsKeyDown(Keys.E))
            {
                if (msc2 == 0)
                {
                    screen = Screen.Story;
                    storymsc.Play();
                    msc2 = 1;
                }
            }
            else if (select >= 21 && select <= 30 && clack.IsKeyDown(Keys.E) || screen == Screen.Losing && clack.IsKeyDown(Keys.Q))
            {
                if (msc3 == 0)
                {
                    screen = Screen.Score;
                    scoremsc.Play();
                    msc3 = 1;
                }
            }
            if (screen == Screen.Story && clack.IsKeyDown(Keys.Q))
            {
                if (msc2 == 1)
                {
                    msc1 = 0;
                    screen = Screen.Intro;
                    storymsc.Dispose();
                    msc2 = 0;
                }
            }
            else if (screen == Screen.Score && clack.IsKeyDown(Keys.Q))
            {
                if (msc3 == 1)
                {
                    msc1 = 0;
                    screen = Screen.Intro;
                    scoremsc.Dispose();
                    msc3 = 0;
                }
            }
            else if (screen == Screen.Intro)
            {
                msc2 = 0;
                msc3 = 0;
            }
            //music
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
                    scoremsc.Dispose();
                    storymsc.Dispose();
                    gamemsc.Dispose();
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
                if (select >= 1 && select <= 10)
                {
                    _spriteBatch.Draw(start2, play, Color.DarkGray);
                }
                else if (select > 10)
                {

                    _spriteBatch.Draw(start2, play, Color.White);
                }
                if (select >= 11 && select <= 20)
                {
                    _spriteBatch.Draw(story2, story, Color.DarkGray);
                }
                else if (select < 11 || select > 20)
                {

                    _spriteBatch.Draw(story2, story, Color.White);
                }
                if (select >= 21 && select <= 30)
                {
                    _spriteBatch.Draw(score2, score, Color.DarkGray);
                }
                else if (select < 21)
                {

                    _spriteBatch.Draw(score2, score, Color.White);
                }
                if (screen == Screen.Game)
                {
                    intromsc.Dispose();
                }
                if (screen == Screen.Story)
                {
                    intromsc.Dispose();
                    if (msc2 == 0)
                    {
                        storymsc.Play();
                        msc2 = 1;
                        msc1 = 0;
                    }
                    _spriteBatch.DrawString(storytext, "Apes have are travelling through time in order to rewrite history.", new Vector2(100, 100), Color.White);
                    _spriteBatch.DrawString(storytext, "It's up to you to stop them. Use your slingshot to stop them.", new Vector2(100, 125), Color.White);
                }
                if (screen == Screen.Score)
                {
                    intromsc.Dispose();
                    if (msc3 == 0)
                    {
                        scoremsc.Play();
                        msc3 = 1;
                        msc1 = 0;
                    }
                }
            }
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}