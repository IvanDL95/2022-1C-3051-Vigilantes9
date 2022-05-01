﻿#region Using Statements

using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#endregion Using Statements

namespace TGC.MonoGame.TP.Models
{
    class WeaponModel
    {
        /// <summary>
        ///     Loads the tank model.
        /// </summary>
        public void Load(Model model)
        {
            // BaseGame.Content.Load<Model>(TGC.MonoGame.TP.TGCGame.ContentFolder3D + "vehicles/CombatVehicle/Vehicle");
            Weapon = model;
            Rotation = Matrix.Identity;
        }

        /// <summary>
        ///     Se llama en cada frame.
        ///     Se debe escribir toda la logica de computo del modelo, asi como tambien verificar entradas del usuario y reacciones
        ///     ante ellas.
        /// </summary>
        public void Update(float elapsedTime)
        {
            // Basado en el tiempo que paso se va generando una rotacion.
            //Rotation = Matrix.CreateRotationY(elapsedTime);
        }

        public void Draw(Matrix World, Matrix View, Matrix Projection)
        {
            // Para dibujar le modelo necesitamos pasarle informacion que el efecto esta esperando.
            foreach (ModelMesh mesh in Weapon.Meshes)
            {
                foreach (BasicEffect effect in mesh.Effects)
                {
                    effect.World = World;
                    effect.View = View;
                    effect.Projection = Projection;
                }

                mesh.Draw();
            }
        }

        #region Fields

        // The XNA framework Model object that we are going to display.
        private Model Weapon;

        private Matrix Rotation { get; set; }

        private Matrix Translation { get; set; }

        private Effect Effect { get; set; }

        #endregion Fields
    }
}
