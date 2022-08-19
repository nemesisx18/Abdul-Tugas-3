using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using SpaceInvader.Module.Message;
using System;
using SpaceInvader.Message;

namespace SpaceInvader.Module.GameOver
{
    public class GameOverController : ObjectController<GameOverController, GameOverModel, IGameOverModel, GameOverView>
    {
        public void GameOver(GameOverMessage message)
        {
            _view.Show();
        }
    }
}