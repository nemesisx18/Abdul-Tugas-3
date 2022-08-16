using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Enemy
{
    public class EnemyModel : BaseModel, IEnemyModel
    {
        public Vector2 walkAmount { get; set; } = new Vector2();
        public float walkDirection { get; set; } = 1f;
        public float originalX { get; set; }
    }
}