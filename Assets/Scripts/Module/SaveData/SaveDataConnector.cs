using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Module.Message;
using SpaceInvader.Module.Score;

namespace SpaceInvader.Module.SaveData
{
    public class SaveDataConnector : BaseConnector
    {
        SaveDataController saveData;
        
        protected override void Connect()
        {
            Subscribe<ScoreDataMessage>(OnEnemyDead);
        }

        protected override void Disconnect()
        {
            Unsubscribe<ScoreDataMessage>(OnEnemyDead);
        }

        public void OnEnemyDead(ScoreDataMessage message)
        {
            saveData.onUpdateScore(message.Score);
        }
    }
}
