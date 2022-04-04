using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Programerings_skit
{
    public class Animation
    {
       int frameCounter;
       int switchFrame;

       Vector2 position, amountofFrames, currentFrame;
       Texture2D Image; 

       public Vector2 CurrentFrame
       {
           get { return currentFrame; }
           set { CurrentFrame = value; }
       }

       public Vector2 Position
       {
           get { return position; }
           set { position = value;}

       }
        public int FrameWidth
        {
            get { return Image.Width / (int)amountofFrames.X;}
        }

         public int FrameHeight
         {
            get { return Image.Height / (int)amountofFrames.Y;}

         }


       public void Initialize()
       {

       }
        public void Update(GameTime gameTime)
        {
            frameCounter += (int)gameTime.ElapsedGameTime.TotalMilliseconds;
            //Gametime har hand om allt som handlar om tid i xna, jag kan veta hur länge jag spelat osv. 
            //Hela gameTime.ElapsedGameTime.TotalMilliseconds betyder antalet millisekunder sedan den senaste frame
            if(frameCounter >= switchFrame)
            {
                frameCounter = 0;
                currentFrame.X += FrameWidth;

            }

        }


        public void Draw(SpriteBatch spritebatch)
        {

        }
    }
}