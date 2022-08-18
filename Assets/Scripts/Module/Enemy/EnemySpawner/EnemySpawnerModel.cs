using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Enemy
{
    public class EnemySpawnerModel : BaseModel, IEnemySpawnerModel
    {
        public List<GameObject> pooledEnemy { get; set; } = new List<GameObject>();
        public EnemyScriptableObject enemyObj { get; private set; }
        public GameObject enemy { get; private set; }

        public int enemyDestroyed { get; private set; }

        public EnemySpawnerModel()
        {
            enemyObj = Resources.Load<EnemyScriptableObject>("NewEnemyData");
        }

        public void AddEnemy()
        {
            enemyDestroyed++;
            SetDataAsDirty();
        }

        public void AddEnemyPool(GameObject go)
        {
            pooledEnemy.Add(go);
            SetDataAsDirty();
        }

        public void ResetEnemy()
        {
            enemyDestroyed = 0;
            SetDataAsDirty();
        }
    }
}