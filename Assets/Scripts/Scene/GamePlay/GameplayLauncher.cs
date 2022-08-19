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
using SpaceInvader.Module.HUD;
using SpaceInvader.Module.GameOver;
using SpaceInvader.Module.Shield;

namespace SpaceInvader.Scene.Gameplay{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";

        HUDController _hud;
        GameOverController _gameOver;
        EnemySpawnerController _enemySpawnerController;
        BulletPoolController _bulletPoolController;
        PlayerController _playerController;
        ShieldController _shieldController;

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {
                new HUDConnector(),
                new GameOverConnector(),
                new PlayerConnector(),
                new BulletPoolConnector(),
                new EnemySpawnerConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
                new HUDController(),
                new GameOverController(),
                new PlayerController(),
                new InputController(),
                new BulletPlayerController(),
                new EnemySpawnerController(),
                new BulletPoolController(),
                new ShieldController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _hud.SetView(_view.HUDView);
            _gameOver.SetView(_view.GameOverView);
            _enemySpawnerController.SetView(_view.EnemySpawnerView);
            _bulletPoolController.SetView(_view.BulletPoolView);
            _playerController.SetView(_view.PlayerView);
            _shieldController.SetView(_view.ShieldView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}