#region Using Statements

using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using TGC.MonoGame.Vigilantes9.Cameras;
using TGC.MonoGame.Vigilantes9.Models;

#endregion Using Statements

namespace TGC.MonoGame.Vigilantes9
{
    public sealed class Player : GameComponent
    {
        public Camera Camera;
        public Vehicle Vehicle;
        
        public Player(Game game, Vehicle vehicle) : base(game)
        {
            Vehicle = vehicle;
        }

        public override void Initialize()
        {   
            Camera = new InGameCamera(Game.GraphicsDevice.Viewport.AspectRatio, this);

            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            Camera.Update(gameTime);

            base.Update(gameTime);
        }

        public Matrix Perspective
        {
            get { return Camera.View * Camera.Projection; }
        }

        public Matrix World
        {
            get { return Vehicle.World; }
        }
    }
}