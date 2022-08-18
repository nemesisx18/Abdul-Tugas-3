using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Module.Message;

namespace SpaceInvader.Module.Enemy
{
    public class EnemySpawnerConnector : BaseConnector
    {
        private EnemySpawnerController _enemySpawner;

        public void OnEnemyDestroy(StartPlayMessage messagee)
        {
            _enemySpawner.OnDestroy();
        }
        
        protected override void Connect()
        {
            Subscribe<StartPlayMessage>(OnEnemyDestroy);
        }

        protected override void Disconnect()
        {
            Unsubscribe<StartPlayMessage>(OnEnemyDestroy);
        }
    }
}