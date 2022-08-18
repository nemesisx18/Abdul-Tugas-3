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
        public float originalX { get; private set; }
        float walkDirection = 1f;
        private UnityAction _onMove;

        public void SetCallback(UnityAction OnMove)
        {
            _onMove = OnMove;
            
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
            Vector2 walkAmount = new Vector2(walkDirection * 0.5f * Time.deltaTime, 0);

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
            Debug.Log(other.gameObject);
            
            if(other.gameObject.CompareTag("Bullet"))
            {
                Destroy(other.gameObject);
                Debug.Log("hitt");
            }
        }
    }
}