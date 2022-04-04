using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Programerings skit
{
    public class Player
    {
        Texture2D playerImage;
        Vector2 playerPosition;

        public void Initialize()
        {

        }

        public void LoadContent(ContentManager Content)
        //ContentManager används för att ladda in the content och den heter "Content"
        {
            playerImage = Content.Load<Texture2D>("Sprites/blackMail");
        }
        public void Update(GameTime gameTime)
        {
            if
        }

        public void Draw(SpriteBatch spritebBatch)
        {

        }


    }
}