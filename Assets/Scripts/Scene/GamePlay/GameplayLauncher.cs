using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Boot;
using SpaceInvader.Module.Enemy;
using SpaceInvader.Module.Bullet;

namespace SpaceInvader.Scene.Gameplay{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";

        EnemySpawnerController _enemySpawnerController;
        BulletPoolController _bulletPoolController;

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]
            {
                
                
                new EnemySpawnerConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
                
                
                
                new EnemySpawnerController(),
                new BulletPoolController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _enemySpawnerController.SetView(_view.EnemySpawnerView);
            _bulletPoolController.SetView(_view.BulletPoolView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}