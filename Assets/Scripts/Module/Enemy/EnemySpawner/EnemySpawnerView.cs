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
        public Vector2 originalPos { get; private set; }
        float walkDirection = 1f;

        private UnityAction onRespawn;
        private Vector3 initialPosition;

        public int rows = 5;
        public int columns = 11;

        public void SetCallback(UnityAction OnRespawn)
        {
            onRespawn = OnRespawn;
        }

        public GameObject SpawnEnemy()
        {
            initialPosition = transform.position;
            GameObject enemy;

            // Form the grid of invaders
            for (int i = 0; i < rows; i++)
            {
                float width = 2f * (columns - 1);
                float height = 2f * (rows - 1);

                Vector2 centerOffset = new Vector2(-width * 0.5f, -height * 0.5f);
                Vector3 rowPosition = new Vector3(centerOffset.x, (2f * i) + centerOffset.y, 0f);

                for (int j = 0; j < columns; j++)
                {
                    // Create an invader and parent it to this transform
                    enemy = Instantiate(_model.enemyObj.enemyObject, transform);

                    // Calculate and set the position of the invader in the row
                    Vector3 position = rowPosition;
                    position.x += 2f * j;
                    enemy.transform.localPosition = position;
                }
            }
            //GameObject enemy = Instantiate(_model.enemyObj.enemyObject, new Vector3(transform.position.x + posX, transform.position.y + posY, transform.position.z) , Quaternion.identity, gameObject.transform);
            
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