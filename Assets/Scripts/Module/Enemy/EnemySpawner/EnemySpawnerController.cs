using UnityEngine;
using Agate.MVC.Base;
using UnityEngine.Events;
using static UnityEngine.RuleTile.TilingRuleOutput;
using UnityEditor.Timeline.Actions;
using static UnityEditor.PlayerSettings;

namespace SpaceInvader.Module.Enemy
{
    public class EnemySpawnerController : ObjectController<EnemySpawnerController, EnemySpawnerModel, IEnemySpawnerModel, EnemySpawnerView>
    {
        //private float ySpawn = 0;
        //private float xSpawn = -1;

        
        public int rows = 3;
        public int columns = 8;

        public bool hasSpawn;

        public void OnDestroy()
        {
            _model.AddEnemy();
        }

        public void OnRespawn()
        {
            if(_model.enemyDestroyed == 24)
            {
                _model.ResetEnemy();
                SpawnEnemy();
                _view.transform.position = _view.originalPos;

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
            for (int i = 0; i < rows; i++)
            {
                float width = 2f * (columns - 4.5f);
                float height = 2f * (rows - 4.5f);

                Vector2 centerOffset = new Vector2(-width * 0.5f, -height * 0.5f);
                Vector3 rowPosition = new Vector3(centerOffset.x, (1f * i) + centerOffset.y, 0f);

                for (int j = 0; j < columns; j++)
                {
                    // Create an invader and parent it to this transform
                    EnemyModel instanceModel = new EnemyModel();
                    GameObject instanceObject = _view.SpawnEnemy();
                    EnemyView instanceView = instanceObject.GetComponent<EnemyView>();
                    EnemyController instance = new EnemyController();
                    InjectDependencies(instance);
                    instance.Init(instanceModel, instanceView);

                    _model.AddEnemyPool(instanceObject);

                    // Calculate and set the position of the invader in the row
                    Vector3 position = rowPosition;
                    position.x += 1f * j;
                    instanceObject.transform.localPosition = position;
                }
            }
        }

        public void SpawnEnemyPool()
        {
            SpawnEnemy();
        }

        private void SpawnEnemy()
        {
            for (int i=0; i < _model.pooledEnemy.Count; i++)
            {
                GameObject enemy = _model.pooledEnemy[i];
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