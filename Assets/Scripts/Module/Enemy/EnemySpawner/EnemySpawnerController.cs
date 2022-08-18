using UnityEngine;
using Agate.MVC.Base;

namespace SpaceInvader.Module.Enemy
{
    public class EnemySpawnerController : ObjectController<EnemySpawnerController, EnemySpawnerModel, IEnemySpawnerModel, EnemySpawnerView>
    {
        //private float ySpawn = 0;
        //private float xSpawn = -1;
        
        public void OnDestroy()
        {
            _model.AddEnemy();
        }

        public void OnRespawn()
        {
            if(_model.enemyDestroyed == 30)
            {
                _model.ResetEnemy();
                SpawnEnemyPool(_view.originalPos);
                
                Debug.Log("game ended");
            }
        }
        
        public void Init(EnemySpawnerModel model, EnemySpawnerView view)
        {
			_model = model;
			SetView(view);
        }

        public void InitEnemyPool()
        {
            for (int i = 0; i < 30; i++)
            {
                //if(xSpawn < 9)
                //{
                //    xSpawn += 1;
                //}
                //else if(xSpawn == 9)
                //{
                //    xSpawn = 0;
                //}

                //if(i % 10 == 0)
                //{
                //    ySpawn += 1;
                //}
                
                EnemyModel instanceModel = new EnemyModel();
                GameObject instanceObject = _view.SpawnEnemy();
                EnemyView instanceView = instanceObject.GetComponent<EnemyView>();
                EnemyController instance = new EnemyController();
                InjectDependencies(instance);
                instance.Init(instanceModel, instanceView);

                _model.AddEnemyPool(instanceObject);
            }
        }

        public void SpawnEnemyPool(Vector2 pos)
        {
            SpawnEnemy(pos);
        }

        private void SpawnEnemy(Vector2 pos)
        {
            for (int i=0; i < _model.pooledEnemy.Count; i++)
            {
                GameObject enemy = _model.pooledEnemy[i];
                enemy.transform.position = pos;
                enemy.SetActive(true);
            }
        }

        public override void SetView(EnemySpawnerView view)
        {
            base.SetView(view);
            view.SetCallback(OnRespawn);
            InitEnemyPool();
        }
    }
}