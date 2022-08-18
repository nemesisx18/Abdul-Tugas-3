using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.SaveData
{
    public class SaveDataController : DataController<SaveDataController, SaveDataModel, ISaveDataModel>
    {
        private void SaveData()
        {
            PlayerPrefs.SetInt("Score", _model.Score);
            PlayerPrefs.Save();
        }

        private void LoadData()
        {
            int score = PlayerPrefs.GetInt("Score");
            _model.SetSCoreData(score);
        }

        public void onUpdateScore(int score)
        {
            _model.SetSCoreData(score);
            Debug.Log("score diterima :" + score);
            SaveData();
        }

        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            LoadData();        
        }
    }
}
