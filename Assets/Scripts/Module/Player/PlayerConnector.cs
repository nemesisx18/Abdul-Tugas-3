using Agate.MVC.Base;
using SpaceInvader.Module.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Player
{
    public class PlayerConnector : BaseConnector
    {
        private PlayerController _player;
        protected override void Connect()
        {
            Subscribe<MovePlayerMessage>(OnControllerMove);
            Subscribe<ShootBulletPlayerMessage>(OnPlayerShoot);
        }

        protected override void Disconnect()
        {
            Unsubscribe<MovePlayerMessage>(OnControllerMove);
            Unsubscribe<ShootBulletPlayerMessage>(OnPlayerShoot);
        }

        void OnControllerMove(MovePlayerMessage message)
        {
            _player.OnMovePlayer(message.X);
        }

        void OnPlayerShoot(ShootBulletPlayerMessage message)
        {
            _player.OnShoot();
        }
    }
}
