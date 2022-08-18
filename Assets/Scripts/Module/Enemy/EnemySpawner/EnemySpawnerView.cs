using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;
using Agate.MVC.Core;
using System;
using SpaceInvader.Message;

namespace SpaceInvader.Module.Enemy
{
    public class EnemySpawnerView : ObjectView<IEnemySpawnerModel>
    {
        [SerializeField] private Transform _transformParent;
        
        public GameObject SpawnEnemy(float posX, float posY)
        {
            GameObject enemy = Instantiate(_model.enemyObj.enemyObject, new Vector3(transform.position.x + posX, transform.position.y + posY, transform.position.z) , Quaternion.identity, _transformParent);

            return enemy;
        }

        protected override void InitRenderModel(IEnemySpawnerModel model)
        {
            
        }

        protected override void UpdateRenderModel(IEnemySpawnerModel model)
        {
            
        }

        private void OnStart()
        {
            Publish<StartPlayMessage>(new StartPlayMessage());
        }
    }
}