using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Boot;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SpaceInvader.Module.MainMenu{
    public class MainMenuLauncher : SceneLauncher<MainMenuLauncher, MainMenuView>
    {
        public override string SceneName => "MainMenu";

        protected override IConnector[] GetSceneConnectors()
        {
            return null;
        }

        protected override IController[] GetSceneDependencies()
        {
            return null;
        }

        protected override IEnumerator InitSceneObject()
        {
            _view.SetCallbacks(OnClickPlayButton);
            return null;
        }

        protected override IEnumerator LaunchScene()
        {
            return null;
        }

        private void OnClickPlayButton()
        {
            SceneManager.LoadScene("Gameplay");
        }
    }
}
