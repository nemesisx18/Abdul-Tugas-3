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
            //for (int i = 0; i < 10; i++)
            //{
            //    GameObject enemy = _view.SpawnEnemy(1.5f * i, 0);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    GameObject enemy = _view.SpawnEnemy(1.5f * i, 1);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    GameObject enemy = _view.SpawnEnemy(1.5f * i, 2);
            //}

            EnemyModel instanceModel = new EnemyModel();
            GameObject instanceObject = _view.SpawnEnemy(1.5f, 0);
            EnemyView instanceView = instanceObject.GetComponent<EnemyView>();
            EnemyController instance = new EnemyController();
            InjectDependencies(instance);
            instance.Init(instanceModel, instanceView);

            Debug.Log(instance);
        }

        public override void SetView(EnemySpawnerView view)
        {
            base.SetView(view);
            InitEnemyPool();
        }
    }
}