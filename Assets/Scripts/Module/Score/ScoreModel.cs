using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Score
{
    public class ScoreModel : BaseModel, IScoreModel
    {
        public int score { get; private set; }

        public void AddScore()
        {
            score += 50;
            SetDataAsDirty();
        }

        public void SetScore(int Score)
        {
            score = Score;
            SetDataAsDirty();
        }
    }
}
