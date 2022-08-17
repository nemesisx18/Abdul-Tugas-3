using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Bullet
{
    public interface IBulletPoolModel : IBaseModel
    {
        public EnemyScriptableObject enemyScriptableObject { get; }
    }
}
