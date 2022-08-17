using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Enemy
{
    public class EnemyModel : BaseModel, IEnemyModel
    {
        public Vector3 Position { get; set; }
        public Vector2 walkAmount { get; set; } = new Vector2();
        public float walkDirection { get; set; } = 1f;
        public float originalX { get; set; }
        public float currentX { get; set; }

        public void SetPosition(Vector3 pos)
        {
            Position = pos;
        }
    }
}