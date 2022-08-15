using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Boot;
using SpaceInvader.Module.Enemy;

namespace SpaceInvader.Scene.Gameplay{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        public override string SceneName => "Gameplay";

        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]
            {
                new EnemyController()
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}