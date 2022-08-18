using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Enemy
{
    public class EnemySpawnerController : ObjectController<EnemySpawnerController, EnemySpawnerModel, IEnemySpawnerModel, EnemySpawnerView>
    {
        private float ySpawn = 0;
        private float xSpawn = -1;
        
        public void Init(EnemySpawnerModel model, EnemySpawnerView view)
        {
			_model = model;
			SetView(view);
        }

        public void InitEnemyPool()
        {
            for (int i = 0; i < 30; i++)
            {
                if(xSpawn < 9)
                {
                    xSpawn += 1;
                }
                else if(xSpawn == 9)
                {
                    xSpawn = 0;
                }

                if(i % 10 == 0)
                {
                    ySpawn += 1;
                }
                
                EnemyModel instanceModel = new EnemyModel();
                GameObject instanceObject = _view.SpawnEnemy(1.5f * xSpawn, ySpawn);
                EnemyView instanceView = instanceObject.GetComponent<EnemyView>();
                EnemyController instance = new EnemyController();
                InjectDependencies(instance);
                instance.Init(instanceModel, instanceView);
            }
        }

        public override void SetView(EnemySpawnerView view)
        {
            base.SetView(view);
            InitEnemyPool();
        }
    }
}