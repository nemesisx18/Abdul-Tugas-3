using System;
using UnityEngine;

namespace SpaceInvader.Module.Message
{
    public struct MovePlayerMessage
    {
        public Vector2 Direction { get; }

        public MovePlayerMessage(Vector2 dir)
        {
            Direction = dir;
        }
    }
}