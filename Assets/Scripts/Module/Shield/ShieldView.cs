using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceInvader.Module.Shield
{
    public class ShieldView : ObjectView<IShieldModel>
    {
        private UnityAction _hitEnemyBullet;

        private int healthShield;


        public void SetCallbacks(UnityAction hitEnemyBullet)
        {
            _hitEnemyBullet = hitEnemyBullet;
        }

        protected override void InitRenderModel(IShieldModel model)
        {
            healthShield = model.HealthShield;
        }

        protected override void UpdateRenderModel(IShieldModel model)
        {
            healthShield = model.HealthShield;
        }

        private void Update()
        {
        }

        /*private void OnTriggerEnter2D(Collider2D collision)
        {
            bool isTriggerWithBulletEnemy = collision.gameObject.CompareTag("BulletEnemy");
            if (isTriggerWithBulletEnemy)
            {
                _hitEnemyBullet?.Invoke();
                collision.gameObject.SetActive(false);
                if (healthShield == 0)
                {
                    gameObject.SetActive(false);
                }
            }
        }*/

        private void OnCollisionEnter2D(Collision2D collision)
        {
            //if (collision.gameObject.CompareTag("BulletEnemy"))
            bool isTriggerWithBulletEnemy = collision.gameObject.CompareTag("BulletEnemy");
            if (isTriggerWithBulletEnemy)
            {
                GetComponent<BoxCollider2D>().enabled = true;
                _hitEnemyBullet?.Invoke();
                collision.gameObject.SetActive(false);
                if (healthShield == 0)
                {
                    gameObject.SetActive(false);
                }
            }
        }


    }
}