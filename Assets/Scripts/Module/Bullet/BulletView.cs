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
            transform.Translate(Vector2.down * Time.deltaTime);
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if(other.gameObject.CompareTag("Player"))
            {
                Debug.Log("player hit");
            }
        }
    }
}
