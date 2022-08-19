using Agate.MVC.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Player{
    public class PlayerModel : BaseModel, IPlayerModel
    {
        public float maxLeft { get; private set; } = -9f;
        public float maxRight { get; private set; }  = 9f;

        public float speed { get; private set; } = 8;

        public Vector2 Direction { get; private set; }

        public Vector2 Position { get; private set; }

        public int Health { get; private set; } = 3;

        public void SetDirection(Vector2 direction)
        {
            Direction = direction ;
            SetDataAsDirty();
        }

        public void SetPosition(Vector2 position)
        {
            Position = position ;
            SetDataAsDirty();
        }

        public void Damaged()
        {
            Health -= 1;
            SetDataAsDirty();
        }
    }
}
