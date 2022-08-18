using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using SpaceInvader.Module.Bullet;

namespace SpaceInvader.Module.Message
{
    public class BulletPoolConnector : BaseConnector
    {
        private BulletPoolController bulletPool;

        protected override void Connect()
        {
            Subscribe<SpawnBulletMessage>(InitSpawn);
        }

        protected override void Disconnect()
        {
            Unsubscribe<SpawnBulletMessage>(InitSpawn);
        }

        void InitSpawn(SpawnBulletMessage message)
        {
            bulletPool.InitPoolBullet(message.Pos);
        }
    }
}