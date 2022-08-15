using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Enemy
{
    public class EnemySpawnerView : ObjectView<IEnemySpawnerModel>
    {
        [SerializeField] private Transform _transformParent;
        
        public GameObject SpawnEnemy(float pos)
        {
            GameObject enemy = Instantiate(_model.enemyObj.enemyObject, new Vector3(transform.position.x + pos, transform.position.y, transform.position.z) , Quaternion.identity, _transformParent);

            return enemy;
        }

        protected override void InitRenderModel(IEnemySpawnerModel model)
        {
            
        }

        protected override void UpdateRenderModel(IEnemySpawnerModel model)
        {
            
        }
    }
}