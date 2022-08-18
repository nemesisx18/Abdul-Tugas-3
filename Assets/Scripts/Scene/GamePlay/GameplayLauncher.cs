using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Boot;
using SpaceInvader.Module.Player;
using SpaceInvader.Module.Input;
using SpaceInvader.Module.BulletPlayer;
using SpaceInvader.Module.Enemy;
using SpaceInvader.Module.Bullet;
using SpaceInvader.Module.Message;
using SpaceInvader.Module.SaveData;
using SpaceInvader.Module.Score;

namespace SpaceInvader.Scene.Gameplay{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";

        EnemySpawnerController _enemySpawnerController;
        BulletPoolController _bulletPoolController;
        PlayerController _playerController;
        ScoreController _scoreController;

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {
                new PlayerConnector(),
                new BulletPoolConnector(),
                new EnemySpawnerConnector(),
                new SaveDataConnector(),
                new ScoreConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
                new PlayerController(),
                new InputController(),
                new BulletPlayerController(),
                new EnemySpawnerController(),
                new BulletPoolController(),
                new SaveDataController(),
                new ScoreController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _enemySpawnerController.SetView(_view.EnemySpawnerView);
            _bulletPoolController.SetView(_view.BulletPoolView);
            _playerController.SetView(_view.PlayerView);
            _scoreController.SetView(_view.ScoreView);

            _view.SetCallbacks(OnClickBackButton);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }

        private void OnClickBackButton()
        {
            SceneLoader.Instance.LoadScene("MainMenu");
        }
    }
}