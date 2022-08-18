using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Bullet
{
    public class BulletView : ObjectView<IBulletModel>
    {
        protected override void InitRenderModel(IBulletModel model)
        {

        }

        protected override void UpdateRenderModel(IBulletModel model)
        {

        }

        void Start()
        {

        }

        void Update()
        {
            transform.Translate(Vector2.up * Time.deltaTime);
        }

        private void OnColliderEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("hit " + other);
            }
        }
    }
}
