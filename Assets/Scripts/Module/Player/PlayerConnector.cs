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
            Subscribe<MovePlayerMessage>(_player.OnMovePlayer);
        }

        protected override void Disconnect()
        {
            Unsubscribe<MovePlayerMessage>(_player.OnMovePlayer);
        }
    }
}
