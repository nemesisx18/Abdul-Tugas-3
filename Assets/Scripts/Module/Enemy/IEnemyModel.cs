using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Enemy
{
    public interface IEnemyModel : IBaseModel
    {
        public Vector2 walkAmount { get; }
        public float walkDirection { get; }
        public float originalX { get; }
    }
}