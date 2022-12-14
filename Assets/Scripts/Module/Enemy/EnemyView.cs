using System;
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
        private UnityAction onDeath;
        public float originalX { get; private set; }
        float walkDirection = 1f;

        public void SetCallback(UnityAction OnDeath)
        {
            onDeath = OnDeath;
        }

        protected override void InitRenderModel(IEnemyModel model)
        {
            
        }

        protected override void UpdateRenderModel(IEnemyModel model)
        {
            
        }

        private void Start()
        {
            originalX = transform.position.x;
        }

        private void Update()
        {
            //MoveEnemy();
        }

        public void MoveEnemy()
        {
            Vector2 walkAmount = new Vector2(walkDirection * 0.2f * Time.deltaTime, 0);

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

        private void OnCollisionEnter2D(Collision2D other)
        {
            if(other.gameObject.CompareTag("Bullet"))
            {
                onDeath?.Invoke();
                other.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
        }
    }
}