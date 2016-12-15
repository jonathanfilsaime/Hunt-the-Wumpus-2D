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
using System.Text;

namespace Assigment2
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont spriteFont;
        SpriteFont instructions;
        SpriteFont caution;
        SpriteFont RoomNumber;
        SpriteFont DeadSprite;
        SpriteFont newInstruction;
        Texture2D Background;
        Texture2D zelda;
        Texture2D Map;
        Texture2D wumpusImage;
        Texture2D pitImage;
        Texture2D superBats;
        Texture2D arrow1;
        Texture2D arrow2;
        Texture2D arrow3;
        Texture2D arrow4;
        Texture2D arrow5;
        private Texture2D cursorTex;
        private Vector2 cursorPos;

        int maxX;
        int maxY;
        int MapXcoordinate;
        int MapYcoordinate;
        int MapWidth = 350;
        int MapHeight = 350;
        int zeldaXcoordinate;
        int zeldaYcoordinate;
        int superBatsXcoordinate = 5000;
        int superBatsYcoordinate = 5000;
        int wumpusXcoordinate = 5000;
        int wumpusYcoordinate = 5000;
        int pitXcoordinate = 5000;
        int pitYcoordinate = 5000;
        int arrow1Xcoordinate = 5000;
        int arrow1Ycoorinate = 5000;
        int arrow2Xcoordinate = 5000;
        int arrow2Ycoorinate = 5000;
        int arrow3Xcoordinate = 5000;
        int arrow3Ycoorinate = 5000;
        int arrow4Xcoordinate = 5000;
        int arrow4Ycoorinate = 5000;
        int arrow5Xcoordinate = 5000;
        int arrow5Ycoorinate = 5000;
        int mouseX;
        int mouseY;
        int count = 0;
        int endWin = -1;

        String capture;
        String DisplayCapture = "Action: ";
        String InstructionString = "Press M to move to another Room \nPress S to shoot an Arrow \nPress Q to Quit";
        String ActionCaution = "Please enter you desire action M-S-Q";
        String MoveCaution = "Please enter a valid room number";
        String ShootCaution = "Please enter a valid sequence";
        String Dead = " ";
        String nullString = "";
        String DisplayCaution = "";
        StringBuilder userInputTemp = new StringBuilder();
        String userInput;
        String newInstructions;

        Position zeldaPosition = new Position();
        int zeldaPlace;
        int zeldaMove;
        Random rnd = new Random();
        int zeldaStartPos;
        int zeldaTempPos;
        int zeldaRead;
        int target;
        int targetTemp1;
        int targetTemp2;
        int targetTemp3;
        int targetTemp4;
        int targetTemp5;
        int arrowCount = 5;
        int x;
        int shootError = 0;

        Rooms room = new Rooms();
        Wumpus wump = new Wumpus();
        Pits pit = new Pits();
        Superbats bats = new Superbats();
        Check check = new Check();
        Arrow arrow = new Arrow();

        Boolean StartMode = true;
        Boolean MoveMode = false;
        Boolean ShootMode = false;
        Boolean DeadMate = false;
        Boolean waitMode = false;
        Boolean winMode = false;
        Boolean littleWait = false;
        Boolean after = true;


        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            cursorTex = Content.Load<Texture2D>("cursor");

            maxX = GraphicsDevice.Viewport.Width;
            maxY = GraphicsDevice.Viewport.Height;
            // Create a new SpriteBatch, which can be used to draw textures.
            Background = Content.Load<Texture2D>("background");

            spriteBatch = new SpriteBatch(GraphicsDevice);
            zelda = Content.Load<Texture2D>("zelda");

            Map = Content.Load<Texture2D>("map");
            MapXcoordinate = (maxX - MapWidth) / 2;
            MapYcoordinate = (maxY - MapHeight) / 2;

            wumpusImage = Content.Load<Texture2D>("wumpus");
            pitImage = Content.Load<Texture2D>("pit");
            superBats = Content.Load<Texture2D>("bats");
            arrow1 = Content.Load<Texture2D>("arrow");
            arrow2 = Content.Load<Texture2D>("arrow");
            arrow3 = Content.Load<Texture2D>("arrow");
            arrow4 = Content.Load<Texture2D>("arrow");
            arrow5 = Content.Load<Texture2D>("arrow");
            //font
            spriteFont = Content.Load<SpriteFont>("basic");
            instructions = Content.Load<SpriteFont>("basic");
            newInstruction = Content.Load<SpriteFont>("basic");
            caution = Content.Load<SpriteFont>("basic");
            DeadSprite = Content.Load<SpriteFont>("IMPACT");

            //rooms
            room.roomSetup();
            room.fillContent();
            room.wampusLocation(wump.randomize());
            room.pitLocation(pit.randomize());
            room.superBatsLocation(bats.randomize());
            zeldaStartPos = rnd.Next(1, 21);

            Console.WriteLine("zelda Start Postion: " + zeldaStartPos);
            
            Console.WriteLine("adjacent 1: " + room.getAdj1(1));
            Console.WriteLine("adjacent 2: " + room.getAdj1(2));

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            KeyboardState kbs = Keyboard.GetState();
            //Console.WriteLine("start mode is: " + StartMode + " and count is: " + count);
            if(StartMode && count == 0)
            {
                newInstructions = "Please enter you desire action M-S-Q";
                if (after)
                {
                    zeldaPosition.setZeldaPos(zeldaStartPos);
                    zeldaXcoordinate = zeldaPosition.getZeldaXPos();
                    zeldaYcoordinate = zeldaPosition.getZeldaYPos();
                    zeldaTempPos = zeldaStartPos;
                    count = 1;
                    DisplayCaution = check.checkAdjacentRooms(room.getContent(room.getAdj1(zeldaTempPos)));
                    DisplayCaution += " " + check.checkAdjacentRooms(room.getContent(room.getAdj2(zeldaTempPos)));
                    DisplayCaution += " " + check.checkAdjacentRooms(room.getContent(room.getAdj3(zeldaTempPos)));
                    after = false;
                }
                count = 1;

                if (check.life(room.getContent(zeldaTempPos)) == 100)
                {
                    wump.setWumpusPos(zeldaTempPos);
                    wumpusXcoordinate = wump.getWumpusXPos();
                    wumpusYcoordinate = wump.getWumpusYPos();
                    Dead = "YOU ARE DEAD";
                    DeadMate = true;
                    MoveMode = false;
                }
                if (check.life(room.getContent(zeldaTempPos)) == 200)
                {
                    pit.setPitPos(zeldaTempPos);
                    pitXcoordinate = pit.getPitXPos();
                    pitYcoordinate = pit.getPitYPos();
                    Dead = "YOU ARE DEAD";
                    DeadMate = true;
                    MoveMode = false;
                }
                if (check.life(room.getContent(zeldaTempPos)) == 300)
                {
                    bats.setsuperBatsPos(zeldaTempPos);
                    superBatsXcoordinate = bats.getsuperBatsXPos();
                    superBatsYcoordinate = bats.getsuperBatsYPos();
                    Dead = "YOU GOT RELOCATED";
                    waitMode = true;
                }

            }
            if (kbs.IsKeyDown(Keys.R))
            {
                //LoadContent();
            }
            if (kbs.IsKeyDown(Keys.M))
            {
                capture = "M";
            }
            if (kbs.IsKeyDown(Keys.S))
            {
                capture = "S";
            }
            if (kbs.IsKeyDown(Keys.Q))
            {
                capture = "Q";
                Exit();
            }
            if (kbs.IsKeyDown(Keys.D0))
            {
                capture = "0";
            }
            if (kbs.IsKeyDown(Keys.D1))
            {
                capture = "1";
            }
            if (kbs.IsKeyDown(Keys.D2))
            {
                capture = "2";
            }
            if (kbs.IsKeyDown(Keys.D3))
            {
                capture = "3";
            }
            if (kbs.IsKeyDown(Keys.D4))
            {
                capture = "4";
            }
            if (kbs.IsKeyDown(Keys.D5))
            {
                capture = "5";
            }
            if (kbs.IsKeyDown(Keys.D6))
            {
                capture = "6";
            }
            if (kbs.IsKeyDown(Keys.D7))
            {
                capture = "7";
            }
            if (kbs.IsKeyDown(Keys.D8))
            {
                capture = "8";
            }
            if (kbs.IsKeyDown(Keys.D9))
            {
                capture = "9";
            }
            if(kbs.IsKeyUp(Keys.D1) && kbs.IsKeyUp(Keys.D2) && kbs.IsKeyUp(Keys.D3) && kbs.IsKeyUp(Keys.D4) && kbs.IsKeyUp(Keys.D5) && kbs.IsKeyUp(Keys.D6)  && kbs.IsKeyUp(Keys.D7) && kbs.IsKeyUp(Keys.D8) && kbs.IsKeyUp(Keys.D9) && kbs.IsKeyUp(Keys.D0) && kbs.IsKeyUp(Keys.M) && kbs.IsKeyUp(Keys.S) && kbs.IsKeyUp(Keys.Q) && kbs.IsKeyUp(Keys.R))
            {
                if(capture != null)
                {
                    if(capture.Equals("0") || capture.Equals("1") || capture.Equals("2") || capture.Equals("3") || capture.Equals("4") || capture.Equals("5") || capture.Equals("6") || capture.Equals("7") || capture.Equals("8") || capture.Equals("9"))
                    {
                        userInputTemp.Append(capture);
                        DisplayCapture = "Action: " + (userInputTemp.ToString());
                        capture = null;
                    }
                    if (capture != null && capture.Equals("M"))
                    {
                        
                        userInputTemp.Append(capture);
                        DisplayCapture = "Action: " + (userInputTemp.ToString());
                        capture = null;
                    }
                    if (capture != null &&  capture.Equals("S"))
                    {
                        userInputTemp.Append(capture);
                        DisplayCapture = "Action: " + (userInputTemp.ToString());
                        capture = null;
                    }
                }
            }
            if(kbs.IsKeyDown(Keys.Enter))
            {
                
                if (StartMode && Int32.TryParse(userInputTemp.ToString(), out zeldaRead))
                {
                    //DisplayCaution = ActionCaution;
                    Console.WriteLine(userInputTemp.ToString());
                    count = 1;
                }
                if (StartMode && userInputTemp.ToString().Equals("M"))
                {
                    newInstructions = "Enter the room you want to move to";
                    StartMode = false;
                    ShootMode = false;
                    MoveMode = true;
                    Console.WriteLine("in start move mode");

                }
                if (StartMode &&  userInputTemp.ToString().Equals("S"))
                {
                    StartMode = false;
                    ShootMode = true;
                    MoveMode = false;
                    Console.WriteLine("in start shoot mode");
                }
                if(DeadMate)
                {

                    System.Threading.Thread.Sleep(3000);
                    Exit();
                }
                if(winMode)
                {
                    wump.setWumpusPos(room.getWumpusLocation());
                    wumpusXcoordinate = wump.getWumpusXPos();
                    wumpusYcoordinate = wump.getWumpusYPos();
                    Dead = "YOU WIN \nYOU KILLED THE WUMPUS";
                    endWin++;
                    if(endWin > 0)
                    {
                        System.Threading.Thread.Sleep(3000);
                        Exit();
                    }       
                }
                if(littleWait)
                {
                    DisplayCaution = "You missed \nThe Wumpus moved";
                    System.Threading.Thread.Sleep(3000);
                    DisplayCaution = "";
                    littleWait = false;
                }
                if(waitMode)
                {
                    DisplayCaution = "";
                    System.Threading.Thread.Sleep(3000);
                    Dead = " ";
                    superBatsXcoordinate = 5000;
                    superBatsYcoordinate = 5000;
                    Random rnd = new Random();
                    zeldaPlace = rnd.Next(1, 20);
                    zeldaPosition.setZeldaPos(zeldaPlace);
                    zeldaXcoordinate = zeldaPosition.getZeldaXPos();
                    zeldaYcoordinate = zeldaPosition.getZeldaYPos();
                    zeldaTempPos = zeldaPlace;
                    DisplayCaution = check.checkAdjacentRooms(room.getContent(room.getAdj1(zeldaTempPos)));
                    DisplayCaution += " " + check.checkAdjacentRooms(room.getContent(room.getAdj2(zeldaTempPos))); 
                    DisplayCaution += " " + check.checkAdjacentRooms(room.getContent(room.getAdj3(zeldaTempPos)));
                    if (check.life(room.getContent(zeldaTempPos)) == 100)
                    {
                        wump.setWumpusPos(zeldaTempPos);
                        wumpusXcoordinate = wump.getWumpusXPos();
                        wumpusYcoordinate = wump.getWumpusYPos();
                        Dead = "YOU ARE DEAD";
                        DeadMate = true;
                        MoveMode = false;
                    }
                    if (check.life(room.getContent(zeldaTempPos)) == 200)
                    {
                        pit.setPitPos(zeldaTempPos);
                        pitXcoordinate = pit.getPitXPos();
                        pitYcoordinate = pit.getPitYPos();
                        Dead = "YOU ARE DEAD";
                        DeadMate = true;
                        MoveMode = false;
                    }
                    if (check.life(room.getContent(zeldaTempPos)) == 300)
                    {
                        bats.setsuperBatsPos(zeldaTempPos);
                        superBatsXcoordinate = bats.getsuperBatsXPos();
                        superBatsYcoordinate = bats.getsuperBatsYPos();
                        Dead = "YOU GOT RELOCATED";
                        waitMode = true;
                    }

                    waitMode = false;
                }
                if (MoveMode)
                {
                    Console.WriteLine("move move mode");
                    userInput = userInputTemp.ToString();
                    Int32.TryParse(userInput, out zeldaPlace);
                    
                    if (Int32.TryParse(userInput, out zeldaRead))
                    {
                        Console.WriteLine("I'm a number " + zeldaRead);
                        Console.WriteLine("zelda pos" + (zeldaTempPos ));

                        if(check.validRoomInput(zeldaRead))
                        {

                            if (check.roomMatch(room.getAdj1(zeldaTempPos), room.getAdj2(zeldaTempPos), room.getAdj3(zeldaTempPos), zeldaRead))
                            {
                                Console.WriteLine("this is an adjacent room " + zeldaRead);

                                zeldaTempPos = zeldaRead;
                                zeldaPlace = zeldaRead;
                                
                                DisplayCaution = check.checkAdjacentRooms(room.getContent(room.getAdj1(zeldaTempPos))) + "\n" + check.checkAdjacentRooms(room.getContent(room.getAdj2(zeldaTempPos))) + "\n" + check.checkAdjacentRooms(room.getContent(room.getAdj3(zeldaTempPos)));


                                zeldaPosition.setZeldaPos(zeldaPlace);
                                zeldaXcoordinate = zeldaPosition.getZeldaXPos();
                                zeldaYcoordinate = zeldaPosition.getZeldaYPos();
                                zeldaTempPos = zeldaPlace;
                                StartMode = true;
                                MoveMode = false;
                                ShootMode = false;
                                count = 0;
                                Console.WriteLine("zeldaTempPos : " + (zeldaTempPos));
                                Console.WriteLine("check life : " + check.life(room.getContent(zeldaTempPos)));

                                if (check.life(room.getContent(zeldaTempPos)) == 100)
                                {
                                    wump.setWumpusPos(zeldaTempPos);
                                    wumpusXcoordinate = wump.getWumpusXPos();
                                    wumpusYcoordinate = wump.getWumpusYPos();
                                    Dead = "YOU ARE DEAD \n THE WUMPUS KILLED YOU";
                                    DeadMate = true;
                                    MoveMode = false;
                                }
                                if (check.life(room.getContent(zeldaTempPos)) == 200)
                                {
                                    pit.setPitPos(zeldaTempPos);
                                    pitXcoordinate = pit.getPitXPos();
                                    pitYcoordinate = pit.getPitYPos();
                                    Dead = "YOU ARE DEAD \n YOU FEEL IN THE PIT YEEEEEE";
                                    DeadMate = true;
                                    MoveMode = false;
                                }  
                                if (check.life(room.getContent(zeldaTempPos)) == 300)
                                {
                                    bats.setsuperBatsPos(zeldaTempPos);
                                    superBatsXcoordinate = bats.getsuperBatsXPos();
                                    superBatsYcoordinate = bats.getsuperBatsYPos();
                                    Dead = "YOU GOT RELOCATED \n THE BATS GOT YOU";
                                    waitMode = true;
                                }
                            }
                            else
                            {
                                Console.WriteLine("room does not match" + zeldaPlace);
                                //DisplayCaution = MoveCaution;
                                newInstructions = "Enter an adjacent room";
                            }
                        }
                        else
                        {
                            Console.WriteLine("I'm not a valid number");
                        }
                    }

                    
                }
                if(ShootMode)
                {
                    Console.WriteLine("shot shot mode");
                    

                    userInput = userInputTemp.ToString();
                    Int32.TryParse(userInput, out x);
                    if( x == 0 && arrowCount == 5)
                    {
                        arrowCount = 0;
                    }

                    if( arrowCount == 0)
                    {
                        if (check.roomMatch(room.getAdj1(zeldaTempPos), room.getAdj2(zeldaTempPos), room.getAdj3(zeldaTempPos), x) && x != zeldaTempPos)
                        {
                            targetTemp1 = x;
                            arrowCount = 1;
                            Console.WriteLine(DisplayCaution);
                            shootError = 0;
                        }
                    }

                    if (arrowCount == 1)
                    {
                        if (check.roomMatch(room.getAdj1(targetTemp1), room.getAdj2(targetTemp1), room.getAdj3(targetTemp1), x) && x != zeldaTempPos)
                        {
                            targetTemp2 = x;
                            arrowCount = 2;
                            Console.WriteLine(DisplayCaution);
                            shootError = 0;
                        }
                    }
                    if (arrowCount == 2)
                    {
                        if (check.roomMatch(room.getAdj1(targetTemp2), room.getAdj2(targetTemp2), room.getAdj3(targetTemp2), x) && x != zeldaTempPos)
                        {
                            targetTemp3 = x;
                            arrowCount = 3;
                            Console.WriteLine(DisplayCaution);
                            shootError = 0;
                        }

                    }
                    if (arrowCount == 3)
                    {
                        if (check.roomMatch(room.getAdj1(targetTemp3), room.getAdj2(targetTemp3), room.getAdj3(targetTemp3), x) && x != zeldaTempPos)
                        {
                            targetTemp4 = x;
                            arrowCount = 4;
                            Console.WriteLine(DisplayCaution);
                            shootError = 0;
                        }
                    }
                    if (arrowCount == 4)
                    {
                        if (check.roomMatch(room.getAdj1(targetTemp4), room.getAdj2(targetTemp4), room.getAdj3(targetTemp4), x) && x != zeldaTempPos)
                        {
                            targetTemp5 = x;
                            arrowCount = 5;
                            shootError = 0;
                            StartMode = true;
                            ShootMode = false;
                            MoveMode = false;
                        }
                    }
                   
                    if(targetTemp1 == 0)
                    {
                        newInstructions = "Enter the 1st room in the arrow's path";
                    }
                    if (targetTemp2 == 0 && targetTemp1 != 0)
                    {
                        newInstructions = "Enter the 2nd room in the arrow's path";

                        arrow.setarrowPos(targetTemp1);
                        arrow1Xcoordinate = arrow.getarrowXPos();
                        arrow1Ycoorinate = arrow.getarrowYPos();
                    }
                    if(targetTemp3 == 0 && targetTemp2 != 0)
                    {
                        newInstructions = "Enter the 3rd room in the arrow's path";

                        arrow.setarrowPos(targetTemp2);
                        arrow2Xcoordinate = arrow.getarrowXPos();
                        arrow2Ycoorinate = arrow.getarrowYPos();
                    }
                    if (targetTemp4 == 0 && targetTemp3 != 0)
                    {
                        newInstructions = "Enter the 4th room in the arrow's path";

                        arrow.setarrowPos(targetTemp3);
                        arrow3Xcoordinate = arrow.getarrowXPos();
                        arrow3Ycoorinate = arrow.getarrowYPos();
                    }
                    if (targetTemp5 == 0 && targetTemp4 != 0)
                    {
                        newInstructions = "Enter the 5th room in the arrow's path";

                        arrow.setarrowPos(targetTemp4);
                        arrow4Xcoordinate = arrow.getarrowXPos();
                        arrow4Ycoorinate = arrow.getarrowYPos();
                    }
                    if(targetTemp5 != 0)
                    {

                        arrow.setarrowPos(targetTemp5);
                        arrow5Xcoordinate = arrow.getarrowXPos();
                        arrow5Ycoorinate = arrow.getarrowYPos();
                        DisplayCaution = ActionCaution;
                    }

                    Console.WriteLine("targetTemp1: " + targetTemp1);
                    Console.WriteLine("targetTemp2: " + targetTemp2);
                    Console.WriteLine("targetTemp3: " + targetTemp3);
                    Console.WriteLine("targetTemp4: " + targetTemp4);
                    Console.WriteLine("targetTemp5: " + targetTemp5);

                    winMode = check.win(targetTemp1, targetTemp2, targetTemp3, targetTemp4, targetTemp5, room.getWumpusLocation());
                    if(!winMode && targetTemp1 != 0 && targetTemp2 != 0 && targetTemp3 != 0 && targetTemp4 != 0 && targetTemp5 != 0)
                    {
                        room.setContentToIndex(room.getWumpusLocation());
                        room.wampusLocation(wump.randomize());
                        newInstructions = "Please enter you desire action M-S-Q";
                        DisplayCaution = "You missed \nThe Wumpus moved";
                        arrow1Xcoordinate = 5000;
                        arrow1Ycoorinate = 5000;
                        arrow2Xcoordinate = 5000;
                        arrow2Ycoorinate = 5000;
                        arrow3Xcoordinate = 5000;
                        arrow3Ycoorinate = 5000;
                        arrow4Xcoordinate = 5000;
                        arrow4Ycoorinate = 5000;
                        arrow5Xcoordinate = 5000;
                        arrow5Ycoorinate = 5000;                            
                        targetTemp1 = 0;
                        targetTemp2 = 0;
                        targetTemp3 = 0;
                        targetTemp4 = 0;                                    
                        targetTemp5  = 0;
                        littleWait = true;
                    }
                  
                }
                
                userInputTemp.Clear();
                DisplayCapture = "Action: ";
                StartMode = true;
            }

            MouseState mouse = Mouse.GetState();
            if(mouse.LeftButton == ButtonState.Pressed)
            {
                mouseX = mouse.X;
                mouseY = mouse.Y;
                Console.WriteLine("X: " + mouseX + " Y: " + mouseY);
            }
            cursorPos = new Vector2(mouse.X, mouse.Y);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkGreen);

            spriteBatch.Begin();
            spriteBatch.Draw(Background, new Rectangle(0, 0, maxX, maxY), null, Color.White);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.Draw(Map, new Rectangle(MapXcoordinate, MapYcoordinate, MapWidth, MapHeight), null, Color.White);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.Draw(zelda, new Rectangle(zeldaXcoordinate, zeldaYcoordinate,40,40), null, Color.White);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.Draw(cursorTex, cursorPos, Color.White);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.DrawString(spriteFont, DisplayCapture,new Vector2(10, 109),Color.Black);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.DrawString(newInstruction, newInstructions, new Vector2(10, 87), Color.Black);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.DrawString(instructions, InstructionString, new Vector2(10, 20), Color.Black);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.DrawString(caution, DisplayCaution, new Vector2(450, 30), Color.Black);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.Draw(wumpusImage, new Rectangle(wumpusXcoordinate, wumpusYcoordinate, 75, 75), null, Color.White);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.Draw(pitImage, new Rectangle(pitXcoordinate, pitYcoordinate, 50, 50), null, Color.White);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.Draw(superBats, new Rectangle(superBatsXcoordinate, superBatsYcoordinate, 100, 100), null, Color.White);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.DrawString(DeadSprite, Dead, new Vector2(493, 90), Color.Red);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.Draw(arrow1, new Rectangle(arrow1Xcoordinate, arrow1Ycoorinate, 50, 50), null, Color.White);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.Draw(arrow2, new Rectangle(arrow2Xcoordinate, arrow2Ycoorinate, 50, 50), null, Color.White);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.Draw(arrow3, new Rectangle(arrow3Xcoordinate, arrow3Ycoorinate, 50, 50), null, Color.White);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.Draw(arrow4, new Rectangle(arrow4Xcoordinate, arrow4Ycoorinate, 50, 50), null, Color.White);
            spriteBatch.End();

            spriteBatch.Begin();
            spriteBatch.Draw(arrow5, new Rectangle(arrow5Xcoordinate, arrow5Ycoorinate, 50, 50), null, Color.White);
            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
