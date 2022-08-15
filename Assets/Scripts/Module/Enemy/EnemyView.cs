using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Enemy
{
    public class EnemyView : ObjectView<IEnemyModel>
    {
        Vector2 walkAmount;
        float walkDirection = 1;
        float originalX;

        private void Start()
        {
            originalX = transform.position.x;
        }

        private void FixedUpdate()
        {
            MoveEnemy();
        }

        public void MoveEnemy()
        {
            walkAmount.x = walkDirection * 1 * Time.deltaTime;

            if (walkDirection > 0.0f && transform.position.x >= originalX + 0.5)
            {
                walkDirection = -1.0f;
                transform.position = new Vector3(transform.position.x,
                    transform.position.y - 1, transform.position.z);
            }
            else if (walkDirection < 0.0f && transform.transform.position.x <= originalX - 0.5)
            {
                walkDirection = 1.0f;
                transform.position = new Vector3(transform.position.x,
                    transform.position.y - 1, transform.position.z);
            }

            transform.Translate(walkAmount);
        }

        protected override void InitRenderModel(IEnemyModel model)
        {
            
        }

        protected override void UpdateRenderModel(IEnemyModel model)
        {
            
        }
    }
}