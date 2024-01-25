using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Threading;

namespace Ape_Invaders
{
    public class Game1 : Game
    {
        enum Screen
        {
            Intro,
            Story,
            Game1,
            Game2,
            Game3,
            Game4,
            Losing,
            Score
        }
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Player spike;
        List<Rectangle> borders;
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
        Texture2D instructions2;
        Texture2D spikeintro;
        Texture2D ape1;
        Texture2D ape2;
        Texture2D ape3;
        Texture2D spikeplay;
        Texture2D blackape;
        Texture2D blueape;
        Texture2D greenape;
        Texture2D redape;
        Texture2D yellowape;
        Texture2D projectile;
        Rectangle play;
        Rectangle instructions;
        Rectangle spkintro;
        Rectangle apeintro1;
        Rectangle apeintro2;
        Rectangle apeintro3;
        Rectangle select1;
        Rectangle select3;
        Rectangle spikes;
        Rectangle scores1;
        Rectangle scores2;
        Rectangle scores3;
        Rectangle scores4;
        Rectangle scores5;
        Rectangle apes1;
        Rectangle apes2;
        Rectangle apes3;
        Rectangle apes4;
        Rectangle apes5;
        Rectangle borders1;
        Rectangle borders2;
        Rectangle borders3;
        Rectangle borders4;
        Rectangle sprjctl;
        Rectangle aprjctl;
        SoundEffect intromsc;
        SoundEffect scoremsc;
        SoundEffect lvlmsc1;
        SoundEffect lvlmsc2;
        SoundEffect lvlmsc3;
        SoundEffect lvlmsc4;
        Vector2 apeMove1;
        Vector2 apeMove2;
        Vector2 apeMove3;
        Vector2 apeMove4;
        Vector2 apeMove5;
        Vector2 sprjctlM;
        Vector2 aprjctlM;
        private SpriteFont words;
        Screen screen;
        MouseState click;
        KeyboardState clack;
        Random generator = new Random();
        int msc1 = 0;
        int msc2 = 0;
        int msc3 = 0;
        int msc4 = 0;
        int select = 1;
        int playing = 0;
        int scores = 0;
        int apecolour1 = 2;
        int apecolour2 = 1;
        int apecolour3 = 4;
        int apecolour4 = 3;
        int apecolour5 = 1;
        int apeplaceY = 50;
        int apeplaceX = 475;
        int apeamount = 1;
        int bcolour = 1;
        int bmsc = 1;
        int sposX = 500;
        int sposY = 535;
        int scorenum1 = 600;
        int scorenum2 = 500;
        int scorenum3 = 400;
        int scorenum4 = 300;
        int scorenum5 = 200;
        int lives = 3;









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
            borders = new List<Rectangle>();
            play = new Rectangle(440, 420, 120, 40);
            instructions = new Rectangle(370, 480, 280, 40);
            select1 = new Rectangle(400, 420, 120, 40);
            select3 = new Rectangle(400, 480, 120, 40);
            spkintro = new Rectangle(80, 10, 222, 285);
            apeintro1 = new Rectangle(600, 30, 150, 150);
            apeintro2 = new Rectangle(735, 30, 132, 222);
            apeintro3 = new Rectangle(825, 30, 230, 252);
            borders.Add(new Rectangle(-2, -50, 1, 700));
            borders.Add(new Rectangle(1001, -50, 1, 700));
            borders.Add(new Rectangle(-2, -2, 1004, 1));
            borders.Add(new Rectangle(-2, 602, 1004, 1));
            borders1 = new Rectangle(-2, -50, 1, 700);
            borders2 = new Rectangle(1001, -50, 1, 700);
            borders3 = new Rectangle(-2, -2, 1004, 1);
            borders4 = new Rectangle(-2, 602, 1004, 1);
            apes1 = new Rectangle(475, 50, 50, 50);
            apes2 = new Rectangle(475, 110, 50, 50);
            apes3 = new Rectangle(475, 170, 50, 50);
            apes4 = new Rectangle(475, 230, 50, 50);
            apes5 = new Rectangle(475, 290, 50, 50);
            sprjctl = new Rectangle(495, 535, 10, 10);
            aprjctl = new Rectangle(495, 285, 10, 10);
            apeMove1 = new Vector2(6, -4);
            apeMove2 = new Vector2(4, 3);
            apeMove3 = new Vector2(-3, 2);
            apeMove4 = new Vector2(-4, -2);
            apeMove5 = new Vector2(3, 3);
            sprjctlM = new Vector2(0, 0);
            aprjctlM = new Vector2(0, 0);
            _graphics.ApplyChanges();
            base.Initialize();
            spike = new Player(spikeplay, 470, 530);
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
            instructions2 = Content.Load<Texture2D>("instructions");
            spikeintro = Content.Load<Texture2D>("spike_intro");
            ape1 = Content.Load<Texture2D>("ape_intro1");
            ape2 = Content.Load<Texture2D>("ape_intro2");
            ape3 = Content.Load<Texture2D>("ape_intro3");
            spikeplay = Content.Load<Texture2D>("spike");
            blackape = Content.Load<Texture2D>("black_ape");
            blueape = Content.Load<Texture2D>("blue_ape");
            greenape = Content.Load<Texture2D>("green_ape");
            redape = Content.Load<Texture2D>("red_ape");
            yellowape = Content.Load<Texture2D>("yellow_ape");
            projectile = Content.Load<Texture2D>("projectiles");
            intromsc = Content.Load<SoundEffect>("titlescreen");
            scoremsc = Content.Load<SoundEffect>("level2");
            lvlmsc1 = Content.Load<SoundEffect>("level1");
            lvlmsc2 = Content.Load<SoundEffect>("level2");
            lvlmsc3 = Content.Load<SoundEffect>("level3");
            lvlmsc4 = Content.Load<SoundEffect>("level4");
            words = Content.Load<SpriteFont>("text1");
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
            if (clack.IsKeyDown(Keys.Down) && select < 2)
            {
                select = select + 1;
            }
            if (clack.IsKeyDown(Keys.Up) && select > 1)
            {
                select = select - 1;
            }
            if (select == 1 && clack.IsKeyDown(Keys.E))
            {
                screen = Screen.Game1;
                
                playing = 1;
            }
            else if (select == 2 && clack.IsKeyDown(Keys.E) || screen == Screen.Losing && clack.IsKeyDown(Keys.Q))
            {
                screen = Screen.Score;
            }
            else if (screen == Screen.Score && clack.IsKeyDown(Keys.Q))
            {
                screen = Screen.Intro;
                select = 1;
                if (select == 1)
                {
                }
            }
            if (screen == Screen.Game1)
            {
                _graphics.PreferredBackBufferWidth = 1000;
                _graphics.PreferredBackBufferHeight = 600;
                _graphics.ApplyChanges();
                if (msc1 == 1)
                {
                    lvlmsc1.Play();
                    msc1 = 2;
                }
                spike.HSpeed = 0;
                spike.VSpeed = 0;
                //straight
                if (clack.IsKeyDown(Keys.D))
                {
                    spike.HSpeed = 3;
                    sposX = sposX + 3;
                }
                else if (clack.IsKeyDown(Keys.A))
                {
                    spike.HSpeed = -3;
                    sposX = sposX - 3;
                }
                else if (clack.IsKeyDown(Keys.W))
                {
                    spike.VSpeed = -3;
                    sposY = sposY - 3;
                }
                else if (clack.IsKeyDown(Keys.S))
                {
                    spike.VSpeed = 3;
                    sposY = sposY + 3;
                }
                //stright

                //diagonal
                if (clack.IsKeyDown(Keys.A) && clack.IsKeyDown(Keys.W))
                {
                    spike.HSpeed = -3;
                    spike.VSpeed = -3;
                    sposX = sposX - 3;
                    sposY = sposY - 3;
                }
                if (clack.IsKeyDown(Keys.A) && clack.IsKeyDown(Keys.S))
                {
                    spike.HSpeed = -3;
                    spike.VSpeed = 3;
                    sposX = sposX - 3;
                    sposY = sposY + 3;
                }
                if (clack.IsKeyDown(Keys.D) && clack.IsKeyDown(Keys.W))
                {
                    spike.HSpeed = 3;
                    spike.VSpeed = -3;
                    sposX = sposX + 3;
                    sposY = sposY - 3;
                }
                if (clack.IsKeyDown(Keys.D) && clack.IsKeyDown(Keys.S))
                {
                    spike.HSpeed = 3;
                    spike.VSpeed = 3;
                    sposX = sposX + 3;
                    sposY = sposY + 3;
                }
                //diagonal

                spike.Update();

                sprjctl.X += (int)sprjctlM.X;
                sprjctl.Y += (int)sprjctlM.Y;
                //lllll
                if (clack.IsKeyUp(Keys.D) && clack.IsKeyUp(Keys.A))
                {
                    sprjctlM.X = 0;
                }
                if (clack.IsKeyUp(Keys.W) && clack.IsKeyUp(Keys.S))
                {
                    sprjctlM.Y = 0;
                }
                else if (clack.IsKeyDown(Keys.A) && clack.IsKeyDown(Keys.D))
                {
                    sprjctlM.X = 3;
                }
                else if (clack.IsKeyDown(Keys.W) && clack.IsKeyDown(Keys.S))
                {
                    sprjctlM.Y = 3;
                }
                //lllll

                //straight
                if (clack.IsKeyDown(Keys.S))
                {
                    sprjctlM.Y = 3;
                }
                if (clack.IsKeyDown(Keys.D))
                {
                    sprjctlM.X = 3;
                }
                if (clack.IsKeyDown(Keys.A))
                {
                    sprjctlM.X = -3;
                }
                if (clack.IsKeyDown(Keys.W))
                {
                    sprjctlM.Y = -3;
                }
                //straight

                //diagonal
                if (clack.IsKeyDown(Keys.A) && clack.IsKeyDown(Keys.W))
                {
                    sprjctlM.X = -3;
                    sprjctlM.Y = -3;
                }
                if (clack.IsKeyDown(Keys.A) && clack.IsKeyDown(Keys.S))
                {
                    sprjctlM.X = -3;
                    sprjctlM.Y = 3;
                }
                if (clack.IsKeyDown(Keys.D) && clack.IsKeyDown(Keys.W))
                {
                    sprjctlM.X = 3;
                    sprjctlM.Y = -3;
                }
                if (clack.IsKeyDown(Keys.D) && clack.IsKeyDown(Keys.S))
                {
                    sprjctlM.X = 3;
                    sprjctlM.Y = 3;
                }
                //diagonal


                if (clack.IsKeyDown(Keys.Left))
                {
                    sprjctlM.X = -5;
                }
                if (clack.IsKeyDown(Keys.Right))
                {
                    sprjctlM.X = 5;
                }
                if (clack.IsKeyDown(Keys.Up))
                {
                    sprjctlM.Y = -5;
                }
                if (clack.IsKeyDown(Keys.Down))
                {
                    sprjctlM.Y = 5;
                }
                if (sprjctl.Intersects(borders1) || sprjctl.Intersects(borders2))
                {
                    sprjctlM.X = 1;
                }
                if (sprjctl.Intersects(borders1) || sprjctl.Intersects(borders2) || sprjctl.Intersects(borders3) || sprjctl.Intersects(borders4) || sprjctl.Intersects(apes1) || sprjctl.Intersects(apes2) || sprjctl.Intersects(apes3) || sprjctl.Intersects(apes4) || sprjctl.Intersects(apes5))
                {
                    sprjctlM.Y = 0;
                    sprjctl = new Rectangle(sposX, sposY, 10, 10);
                    _spriteBatch.Begin();
                    _spriteBatch.Draw(projectile, sprjctl, Color.LightBlue);
                    _spriteBatch.End();
                }
                foreach (Rectangle barrier in borders)
                    if (spike.Collide(barrier))
                    {
                        spike.UndoMove();
                        sprjctlM.X = 0;
                    }
                apes1.X += (int)apeMove1.X;
                apes2.X += (int)apeMove2.X;
                apes3.X += (int)apeMove3.X;
                apes4.X += (int)apeMove4.X;
                apes5.X += (int)apeMove5.X;
                apes1.Y += (int)apeMove1.Y;
                apes2.Y += (int)apeMove2.Y;
                apes3.Y += (int)apeMove3.Y;
                apes4.Y += (int)apeMove4.Y;
                apes5.Y += (int)apeMove5.Y;
                if (apes1.Intersects(borders1) || apes1.Intersects(borders2))
                {
                    apeMove1.X *= -1;
                }
                if (apes2.Intersects(borders1) || apes2.Intersects(borders2))
                {
                    apeMove2.X *= -1;
                }
                if (apes3.Intersects(borders1) || apes3.Intersects(borders2))
                {
                    apeMove3.X *= -1;
                }
                if (apes4.Intersects(borders1) || apes4.Intersects(borders2))
                {
                    apeMove4.X *= -1;
                }
                if (apes5.Intersects(borders1) || apes5.Intersects(borders2))
                {
                    apeMove5.X *= -1;
                }
                if (apes1.Intersects(borders3) || apes1.Intersects(borders4))
                {
                    apeMove1.Y *= -1;
                }
                if (apes2.Intersects(borders3) || apes2.Intersects(borders4))
                {
                    apeMove2.Y *= -1;
                }
                if (apes3.Intersects(borders3) || apes3.Intersects(borders4))
                {
                    apeMove3.Y *= -1;
                }
                if (apes4.Intersects(borders3) || apes4.Intersects(borders4))
                {
                    apeMove4.Y *= -1;
                }
                if (apes5.Intersects(borders3) || apes5.Intersects(borders4))
                {
                    apeMove5.Y *= -1;
                }
                if (sprjctl.Intersects(apes1))
                {
                    apes1 = new Rectangle(-50, -50, 1, 1);
                    scores = scores + 40;
                }
                if (sprjctl.Intersects(apes2))
                {
                    apes2 = new Rectangle(-50, -50, 1, 1);
                    scores = scores + 40;
                }
                if (sprjctl.Intersects(apes3))
                {
                    apes3 = new Rectangle(-50, -50, 1, 1);
                    scores = scores + 40;
                }
                if (sprjctl.Intersects(apes4))
                {
                    apes4 = new Rectangle(-50, -50, 1, 1);
                    scores = scores + 40;
                }
                if (sprjctl.Intersects(apes5))
                {
                    apes5 = new Rectangle(-50, -50, 1, 1);
                    scores = scores + 40;
                }
                if (apes1.Intersects(spike) || apes2.Intersects(spike) || apes3.Intersects(spike) || apes4.Intersects(spike) || apes5.Intersects(spike))
            }
            else if (screen == Screen.Score)
            {
                _graphics.PreferredBackBufferWidth = 1400;
                _graphics.PreferredBackBufferHeight = 600;
                _graphics.ApplyChanges();
            }
            else if (screen == Screen.Intro)
            {
                _graphics.PreferredBackBufferWidth = 1000;
                _graphics.PreferredBackBufferHeight = 600;
                _graphics.ApplyChanges();
                if (msc1 == 0)
                {
                    intromsc.Play();
                    msc1 = 1;
                }
            }
            base.Update(gameTime);
        }














        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();


            //intro
            if (screen == Screen.Intro)
            {
                scoremsc.Dispose();
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
                    _spriteBatch.Draw(instructions2, instructions, Color.White);
                    if (clack.IsKeyDown(Keys.E))
                    {
                        intromsc.Dispose();
                        screen = Screen.Game1;
                    }
                }
                else if (select == 2)
                {
                    _spriteBatch.Draw(instructions2, instructions, Color.DarkGray);
                    _spriteBatch.Draw(start2, play, Color.White);
                    if (clack.IsKeyDown(Keys.E))
                    {
                        screen = Screen.Score;
                    }
                }
            }
            //intro



            //game1
            else if (screen == Screen.Game1)
            {
                intromsc.Dispose();
                if (msc1 == 1)
                {
                    lvlmsc1.Play();
                    msc1 = 2;
                }
                if (msc1 == 3)
                {
                    lvlmsc1.Dispose();
                    lvlmsc2.Play();
                    msc1 = 4;
                }
                if (msc1 == 5)
                {
                    lvlmsc2.Dispose();
                    lvlmsc3.Play();
                    msc1 = 6;
                }
                if (msc1 == 7)
                {
                    lvlmsc3.Dispose();
                    lvlmsc4.Play();
                    msc1 = 8;
                }
                if (bcolour == 1)
                {
                    GraphicsDevice.Clear(Color.LimeGreen);
                }
                else if (bcolour == 2)
                {
                    GraphicsDevice.Clear(Color.MonoGameOrange);
                }
                else if (bcolour == 3)
                {
                    GraphicsDevice.Clear(Color.Purple);
                }
                else if (bcolour == 4)
                {
                    GraphicsDevice.Clear(Color.Gray);
                }
                _spriteBatch.Draw(projectile, sprjctl, Color.LightBlue);
                spike.Draw(_spriteBatch);
                //ape1
                if (apecolour1 == 1)
                {
                    _spriteBatch.Draw(yellowape, apes1, Color.White);
                }
                if (apecolour1 == 2)
                {
                    _spriteBatch.Draw(blueape, apes1, Color.White);
                }
                if (apecolour1 == 3)
                {
                    _spriteBatch.Draw(redape, apes1, Color.White);
                }
                if (apecolour1 == 4)
                {
                    _spriteBatch.Draw(greenape, apes1, Color.White);
                }
                //ape1

                //ape2
                if (apecolour2 == 1)
                {
                    _spriteBatch.Draw(yellowape, apes2, Color.White);
                }
                if (apecolour2 == 2)
                {
                    _spriteBatch.Draw(blueape, apes2, Color.White);
                }
                if (apecolour2 == 3)
                {
                    _spriteBatch.Draw(redape, apes2, Color.White);
                }
                if (apecolour2 == 4)
                {
                    _spriteBatch.Draw(greenape, apes2, Color.White);
                }
                //ape2

                //ape3
                if (apecolour3 == 1)
                {
                    _spriteBatch.Draw(yellowape, apes3, Color.White);
                }
                if (apecolour3 == 2)
                {
                    _spriteBatch.Draw(blueape, apes3, Color.White);
                }
                if (apecolour3 == 3)
                {
                    _spriteBatch.Draw(redape, apes3, Color.White);
                }
                if (apecolour3 == 4)
                {
                    _spriteBatch.Draw(greenape, apes3, Color.White);
                }
                //ape3

                //ape4
                if (apecolour4 == 1)
                {
                    _spriteBatch.Draw(yellowape, apes4, Color.White);
                }
                if (apecolour4 == 2)
                {
                    _spriteBatch.Draw(blueape, apes4, Color.White);
                }
                if (apecolour4 == 3)
                {
                    _spriteBatch.Draw(redape, apes4, Color.White);
                }
                if (apecolour4 == 4)
                {
                    _spriteBatch.Draw(greenape, apes4, Color.White);
                }
                //ape4

                //ape5
                if (apecolour5 == 1)
                {
                    _spriteBatch.Draw(yellowape, apes5, Color.White);
                }
                if (apecolour5 == 2)
                {
                    _spriteBatch.Draw(blueape, apes5, Color.White);
                }
                if (apecolour5 == 3)
                {
                    _spriteBatch.Draw(redape, apes5, Color.White);
                }
                if (apecolour5 == 4)
                {
                    
                    _spriteBatch.Draw(greenape, apes5, Color.White);
                }
                //ape5
                _spriteBatch.Draw(blueape, apes1, Color.White);
                _spriteBatch.Draw(yellowape, apes2, Color.White);
                _spriteBatch.Draw(yellowape, apes3, Color.White);
                _spriteBatch.Draw(yellowape, apes4, Color.White);
                _spriteBatch.Draw(yellowape, apes5, Color.White);
                if (scores == 200 || scores == 401 || scores == 602 || scores == 803 || scores == 1004 || scores == 1205 || scores == 1406 || scores == 1607 || scores == 1808 || scores == 2009)
                {
                    bcolour = generator.Next(1, 5);
                    if (apecolour1 <= 4)
                    {
                        apecolour1 = apecolour1 + 1;
                    }
                    else if (apecolour1 == 5)
                    {
                        apecolour1 = 1;
                    }
                    if (apecolour2 <= 4)
                    {
                        apecolour2 = apecolour2 + 1;
                    }
                    else if (apecolour2 == 5)
                    {
                        apecolour2 = 1;
                    }
                    if (apecolour3 <= 4)
                    {
                        apecolour3 = apecolour3 + 1;
                    }
                    else if (apecolour3 == 5)
                    {
                        apecolour3 = 1;
                    }
                    if (apecolour4 <= 4)
                    {
                        apecolour4 = apecolour4 + 1;
                    }
                    else if (apecolour4 == 5)
                    {
                        apecolour4 = 1;
                    }
                    if (apecolour5 <= 4)
                    {
                        apecolour5 = apecolour5 + 1;
                    }
                    else if (apecolour5 == 5)
                    {
                        apecolour5 = 1;
                    }
                    apes1 = new Rectangle(475, 50, 50, 50);
                    apes2 = new Rectangle(475, 110, 50, 50);
                    apes3 = new Rectangle(475, 170, 50, 50);
                    apes4 = new Rectangle(475, 230, 50, 50);
                    apes5 = new Rectangle(475, 290, 50, 50);
                    msc1 = msc1 + 1;
                    scores = scores + 1;
                }

            }
            //game1




            //score
            else if (screen == Screen.Score)
            {
                GraphicsDevice.Clear(Color.Green);
                _spriteBatch.DrawString(words, "Use the WASD keys to move.", new Vector2(18, 48), Color.Black);
                _spriteBatch.DrawString(words, "Use the WASD keys to move.", new Vector2(20, 50), Color.Yellow);
                _spriteBatch.DrawString(words, "Use the arrow keys to shoot.", new Vector2(8, 108), Color.Black);
                _spriteBatch.DrawString(words, "Use the arrow keys to shoot.", new Vector2(10, 110), Color.Yellow);
                _spriteBatch.DrawString(words, "Wipe out all the apes.", new Vector2(28, 168), Color.Black);
                _spriteBatch.DrawString(words, "Wipe out all the apes.", new Vector2(30, 170), Color.Yellow);
                _spriteBatch.DrawString(words, "Good luck.", new Vector2(38, 228), Color.Black);
                _spriteBatch.DrawString(words, "Good luck.", new Vector2(40, 230), Color.Yellow);
            }
            //score


            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}