using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEngine;

namespace SpaceInvader.Module.Enemy
{
    public interface IEnemySpawnerModel : IBaseModel
    {
        public EnemyScriptableObject enemyObj { get; }
        public GameObject enemy { get; }
    }

}