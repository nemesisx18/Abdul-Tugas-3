using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Message;

namespace SpaceInvader.Module.Enemy
{
    public class EnemySpawnerConnector : BaseConnector
    {
        private EnemySpawnerController _enemySpawner;

        public void InitEnemyPool(StartPlayMessage messagee)
        {
            _enemySpawner.InitEnemyPool();
        }
        
        protected override void Connect()
        {
            Subscribe<StartPlayMessage>(InitEnemyPool);
        }

        protected override void Disconnect()
        {
            Unsubscribe<StartPlayMessage>(InitEnemyPool);
        }
    }
}