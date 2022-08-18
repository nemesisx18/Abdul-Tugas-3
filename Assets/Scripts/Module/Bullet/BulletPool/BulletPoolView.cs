using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Bullet
{
    public class BulletPoolView : ObjectView<IBulletPoolModel>
    {
        protected override void InitRenderModel(IBulletPoolModel model)
        {
            
        }

        protected override void UpdateRenderModel(IBulletPoolModel model)
        {
            
        }

        public GameObject SpawnBullet(GameObject gameObject)
        {
            GameObject enemy = Instantiate(gameObject, this.gameObject.transform);
            return enemy;
        }
    }
}
