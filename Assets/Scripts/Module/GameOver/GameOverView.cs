using Agate.MVC.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.GameOver
{
    public class GameOverView : ObjectView<IGameOverModel>
    {
        [SerializeField] private GameObject _gameOverPopup;


        public void Show()
        {
            _gameOverPopup.SetActive(true);
        }

        protected override void InitRenderModel(IGameOverModel model)
        {
            //throw new System.NotImplementedException();
        }

        protected override void UpdateRenderModel(IGameOverModel model)
        {
            //throw new System.NotImplementedException();
        }
    }
}