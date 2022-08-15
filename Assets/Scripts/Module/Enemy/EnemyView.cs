using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Enemy
{

    public class EnemyView : BaseView
    {
        [SerializeField] private Transform enemy;
        private List<Transform> enemyList = new List<Transform>();

        Vector3 walkAmount;
        float walkDirection = 1f;
        float originalX;

        private void Start()
        {
            Spawner();

            originalX = enemy.transform.position.x;
        }

        private void FixedUpdate()
        {
            MoveEnemy();
        }

        public void Spawner()
        {
            enemy.gameObject.SetActive(true);

            foreach (Transform tr in enemy.GetComponentInChildren<Transform>())
            {
                enemyList.Add(tr.transform);
            }
        }

        public void MoveEnemy()
        {
            walkAmount.x = walkDirection * 1 * Time.deltaTime;

            if (walkDirection > 0.0f && enemy.position.x >= originalX + 2.5)
            {
                walkDirection = -1.0f;
                enemy.position = new Vector3(enemy.position.x, 
                    enemy.position.y - 1, enemy.position.z);
            }
            else if (walkDirection < 0.0f && enemy.transform.position.x <= originalX - 2.5)
            {
                walkDirection = 1.0f;
                enemy.position = new Vector3(enemy.position.x, 
                    enemy.position.y - 1, enemy.position.z);
            }
            enemy.transform.Translate(walkAmount);
        }
    }
}