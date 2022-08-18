using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Enemy
{
    public class EnemySpawnerConnector : BaseConnector
    {
        private EnemySpawnerController _enemySpawner;

        protected override void Connect()
        {
            Subscribe<StartPlayMessage>(_enemySpawner.InitEnemyPool);
        }

        protected override void Disconnect()
        {
            Unsubscribe<StartPlayMessage>(_enemySpawner.InitEnemyPool);
        }
    }
}