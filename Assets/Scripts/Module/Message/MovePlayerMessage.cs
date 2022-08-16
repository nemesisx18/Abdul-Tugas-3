using System;
using UnityEngine;

namespace SpaceInvader.Module.Message
{
    public struct MovePlayerMessage
    {
        public int DirectionX { get; private set; }

        public MovePlayerMessage(int dir)
        {
            DirectionX = dir;
        }
    }
}