using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Module.Message;

namespace SpaceInvader.Module.Score
{
    public class ScoreConnector : BaseConnector
    {
        ScoreController ScoreController;
        
        protected override void Connect()
        {
            Subscribe<StartPlayMessage>(OnEnemyDead);
        }

        protected override void Disconnect()
        {
            Unsubscribe<StartPlayMessage>(OnEnemyDead);
        }

        public void OnEnemyDead(StartPlayMessage message)
        {
            ScoreController.OnEnemyDead();
        }
    }
}
