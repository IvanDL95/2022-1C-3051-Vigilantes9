﻿using System;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TGC.MonoGame.Collisions;

namespace TGC.MonoGame.TP.Models
{
    class SimpleVehicle : Vehicle
    {
        public SimpleVehicle(Game game) : base(game)
        {
        }

        public override void LoadContent()
        {
            Model = Game.Content.Load<Model>(TGCContent.ContentFolder3D + "vehicles/Car/car");
            Effect = Game.Content.Load<Effect>(TGCContent.ContentFolderEffects + "TextShader");
            var effect = Model.Meshes.FirstOrDefault().Effects.FirstOrDefault() as BasicEffect;
            Effect.Parameters["ModelTexture"].SetValue(effect.Texture);

            foreach (var mesh in Model.Meshes)
                foreach (var meshPart in mesh.MeshParts)
                    meshPart.Effect = Effect;

            Collider = BoundingVolumesExtensions.CreateAABBFrom(Model);
            Collider = new BoundingBox(Collider.Min + Position, Collider.Max + Position);
        }
    }
}
