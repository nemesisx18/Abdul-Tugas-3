using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Message;

namespace SpaceInvader.Module.Bullet
{

    public class BulletPoolConnector : BaseConnector
    {
        BulletPoolController controller;

        public void InitBulletPool(StartPlayMessage message)
        {
            controller.InitBulletPool();
        }
        
        protected override void Connect()
        {
            Subscribe<StartPlayMessage>(InitBulletPool);
        }

        protected override void Disconnect()
        {
            Unsubscribe<StartPlayMessage>(InitBulletPool);
        }
    }
}
