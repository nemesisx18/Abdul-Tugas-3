using Agate.MVC.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Player{
    public class PlayerModel : BaseModel, IPlayerModel
    {
        public float maxLeft { get; private set; } = -8f;
        public float maxRight { get; private set; }  = 8f;

        public float speed { get; private set; } = 10;

        public Vector2 Direction { get; private set; }

        //public Vector2 Position { get; private set; }

        public void SetDirection(Vector2 direction)
        {
            Direction = direction ;
            SetDataAsDirty();
        }
    }
}
