using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Bullet
{
    public class BulletView : ObjectView<IBulletModel>
    {
        private float speed = 5;
        
        protected override void InitRenderModel(IBulletModel model)
        {

        }

        protected override void UpdateRenderModel(IBulletModel model)
        {

        }

        void Update()
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);

            if(transform.position.y > 5)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
