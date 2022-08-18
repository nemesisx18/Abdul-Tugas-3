using Agate.MVC.Base;
using SpaceInvader.Message;
using SpaceInvader.Module.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.GameOver
{
    public class GameOverConnector : BaseConnector
    {
        private GameOverController _gameOver;

        protected override void Connect()
        {
            Subscribe<GameOverMessage>(_gameOver.GameOver);
        }

        protected override void Disconnect()
        {
            Unsubscribe<GameOverMessage>(_gameOver.GameOver);
        }
    }
}
