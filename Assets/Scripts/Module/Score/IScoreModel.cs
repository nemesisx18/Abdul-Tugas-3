using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Score
{
    public interface IScoreModel : IBaseModel
    {
        public int score { get; }
    }
}
