using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.SaveData
{
    public interface ISaveDataModel : IBaseModel
    {
        public int Score { get; }
    }
}