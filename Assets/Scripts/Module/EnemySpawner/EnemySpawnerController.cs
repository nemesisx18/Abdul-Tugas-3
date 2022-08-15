using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Enemy
{
    public class EnemySpawnerController : ObjectController<EnemySpawnerController, EnemySpawnerModel, IEnemySpawnerModel, EnemySpawnerView>
    {
        public void Init(EnemySpawnerModel model, EnemySpawnerView view)
        {
			_model = model;
			SetView(view);
        }

        public void InitEnemyPool()
        {
            for (int i = 0; i < 10; i++)
            {
                GameObject enemy = _view.SpawnEnemy(1.5f * i);
            }
        }

        public override void SetView(EnemySpawnerView view)
        {
            base.SetView(view);
            InitEnemyPool();
        }
    }
}