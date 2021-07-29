using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bricks
{
    class GameBorder
    {
        public float Width { get; set; } // Width of game
        public float Height { get; set; } // Height of game

        private Texture2D imgPixel { get; set; }
        private SpriteBatch spriteBatch;

        public GameBorder(float screenWidth, float screenHeight, SpriteBatch spriteBatch, GameContent gameContent)
        {
            Width = screenWidth;
            Height = screenHeight;
            imgPixel = gameContent.Pixel;
            this.spriteBatch = spriteBatch;
        }

        public void Draw()
        {
            spriteBatch.Draw(imgPixel, new Rectangle(0, 0, (int)Width - 1, 1), Color.Black); // Draw top border
            spriteBatch.Draw(imgPixel, new Rectangle(0, 0,  1, (int)Height - 1), Color.Black); // Draw left border
            spriteBatch.Draw(imgPixel, new Rectangle((int)Width - 1, 0, 1, (int)Height - 1), Color.Black); // Draw left border
        }
    }
}
