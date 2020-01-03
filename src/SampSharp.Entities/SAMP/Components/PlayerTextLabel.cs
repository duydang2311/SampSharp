﻿using SampSharp.Entities.SAMP.NativeComponents;

namespace SampSharp.Entities.SAMP.Components
{
    /// <summary>
    /// Represents a component which provides the data and functionality of a player 3D text label.
    /// </summary>
    public class PlayerTextLabel : Component
    {
        public PlayerTextLabel(string text, Color color, Vector3 position, float drawDistance, int virtualWorld,
            bool testLos, Entity attachedEntity)
        {
            Text = text;
            Color = color;
            Position = position;
            DrawDistance = drawDistance;
            VirtualWorld = virtualWorld;
            TestLos = testLos;
            AttachedEntity = attachedEntity;
        }

        /// <summary>
        /// Gets the color of this player text label.
        /// </summary>
        public virtual Color Color { get; }

        /// <summary>
        /// Gets the text of this player text label.
        /// </summary>
        public virtual string Text { get; }

        /// <summary>
        /// Gets the position of this player text label.
        /// </summary>
        public virtual Vector3 Position { get; }

        /// <summary>
        /// Gets the draw distance.
        /// </summary>
        public virtual float DrawDistance { get; }

        /// <summary>
        /// Gets the virtual world.
        /// </summary>
        public int VirtualWorld { get; }

        /// <summary>
        /// Gets a value indicating whether to test the line of sight.
        /// </summary>
        public virtual bool TestLos { get; }

        /// <summary>
        /// Gets the attached entity.
        /// </summary>
        public virtual Entity AttachedEntity { get; }

        /// <inheritdoc />
        protected override void OnDestroyComponent()
        {
            GetComponent<NativePlayerTextLabel>().DeletePlayer3DTextLabel();
        }
    }
}