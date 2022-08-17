using System;
using UnityEngine;

namespace SpaceInvader.Module.Message
{
    public struct MovePlayerMessage
    {
        public float X {get; private set;}

        public MovePlayerMessage(float x)
        {
            X = x;
        }
    }
}