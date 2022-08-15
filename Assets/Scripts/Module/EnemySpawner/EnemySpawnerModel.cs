using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Enemy
{
    public class EnemySpawnerModel : BaseModel, IEnemySpawnerModel
    {
        public EnemyScriptableObject enemyObj { get; private set; }
        public GameObject enemy { get; private set; }

        public EnemySpawnerModel()
        {
            enemyObj = Resources.Load<EnemyScriptableObject>("NewEnemyData");
        }
    }
}