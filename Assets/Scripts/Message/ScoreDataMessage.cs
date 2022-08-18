using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace SpaceInvader.Module.Message
{
    public struct ScoreDataMessage
    {
        public int Score;

        public ScoreDataMessage(int _score)
        {
            Score = _score;
        }
    }
}
