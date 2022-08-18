using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;
using Agate.MVC.Core;
using UnityEditor.Timeline.Actions;

namespace SpaceInvader.Module.Enemy
{
    public class EnemySpawnerView : ObjectView<IEnemySpawnerModel>
    {
        private UnityAction onRespawn;
        public Vector2 originalPos { get; private set; }
        float walkDirection = 1f;

        

        public void SetCallback(UnityAction OnRespawn)
        {
            onRespawn = OnRespawn;
        }

        public GameObject SpawnEnemy()
        {
            //GameObject enemy = Instantiate(_model.enemyObj.enemyObject, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity, gameObject.transform);
            GameObject enemy = Instantiate(_model.enemyObj.enemyObject, transform);

            return enemy;

        }

        protected override void InitRenderModel(IEnemySpawnerModel model)
        {
            
        }

        protected override void UpdateRenderModel(IEnemySpawnerModel model)
        {
            
        }

        private void Start()
        {
            originalPos = transform.position;
        }

        private void Update()
        {
            onRespawn?.Invoke();
        }

        private void FixedUpdate()
        {
            MoveEnemy();
        }

        public void MoveEnemy()
        {
            Vector2 walkAmount = new Vector2(walkDirection * 0.25f * Time.deltaTime, 0);

            if (walkDirection > 0.0f && transform.position.x >= originalPos.x + 2.5)
            {
                walkDirection = -1.0f;
                transform.position = new Vector3(transform.position.x,
                    transform.position.y - 1, transform.position.z);
            }
            else if (walkDirection < 0.0f && transform.transform.position.x <= originalPos.x - 2.5)
            {
                walkDirection = 1.0f;
                transform.position = new Vector3(transform.position.x,
                    transform.position.y - 1, transform.position.z);
            }

            transform.Translate(walkAmount);
        }
    }
}