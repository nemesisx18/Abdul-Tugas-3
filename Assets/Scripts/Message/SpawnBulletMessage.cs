using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Message
{
    public struct SpawnBulletMessage
    {
        public Vector2 Pos { get; private set; }

        public SpawnBulletMessage(Vector2 pos)
        {
            Pos = pos;
        }
    }
}