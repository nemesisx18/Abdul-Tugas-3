using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.SaveData
{
    public class SaveDataModel : BaseModel, ISaveDataModel
    {
        public int Score { get; private set; }

        public void SetSCoreData(int score)
        {
            Score = score;
            SetDataAsDirty();
        }
    }
}
