using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Module.SaveData;
using SpaceInvader.Module.Message;

namespace SpaceInvader.Module.Score
{
    public class ScoreController : ObjectController<ScoreController, ScoreModel, IScoreModel, ScoreView>
    {
        SaveDataController _saveData;
        
        public void OnEnemyDead()
        {
            _model.AddScore();
            Publish<ScoreDataMessage>(new ScoreDataMessage(_model.score));
        }

        public override IEnumerator Finalize()
        {
            yield return base.Finalize();
            _model.SetScore(_saveData.Model.Score);
        }
    }
}
