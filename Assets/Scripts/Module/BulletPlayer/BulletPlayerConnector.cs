using Agate.MVC.Base;
using SpaceInvader.Module.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.BulletPlayer
{
    public class BulletPlayerConnector : BaseConnector
    {
        private BulletPlayerController _bulletPlayer;

        protected override void Connect()
        {
            Subscribe<ShootBulletPlayerMessage>(_bulletPlayer.OnShootBulletPlayer);
        }

        protected override void Disconnect()
        {
            Unsubscribe<ShootBulletPlayerMessage>(_bulletPlayer.OnShootBulletPlayer);
        }
    }
}
