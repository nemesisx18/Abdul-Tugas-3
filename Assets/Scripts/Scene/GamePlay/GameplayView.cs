using Agate.MVC.Base;
using SpaceInvader.Module.Player;
using SpaceInvader.Module.Enemy;
using SpaceInvader.Module.Bullet;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceInvader.Module.HUD;
using SpaceInvader.Module.GameOver;
using SpaceInvader.Module.Shield;
using UnityEngine.UI;
using SpaceInvader.Module.Score;
using UnityEngine.Events;

namespace SpaceInvader.Scene.Gameplay
{
	public class GameplayView : BaseSceneView
	{
		[SerializeField] HUDView hudView;
		[SerializeField] GameOverView gameOverView;
		[SerializeField] EnemySpawnerView enemySpawnerView;
		[SerializeField] BulletPoolView bulletPoolView;
		[SerializeField] ScoreView scoreView;
		[SerializeField] PlayerView playerView;
		[SerializeField] ShieldView shieldView;

		[SerializeField] private Button _backButton;

		public EnemySpawnerView EnemySpawnerView => enemySpawnerView;

		public BulletPoolView BulletPoolView => bulletPoolView;
		public ScoreView ScoreView => scoreView;

		public PlayerView PlayerView => playerView;

		public HUDView HUDView => hudView;

		public GameOverView GameOverView => gameOverView;

		public ShieldView ShieldView => shieldView;
	}

        public void SetCallbacks(UnityAction onClickBackButton)
        {
            _backButton.onClick.RemoveAllListeners();
            _backButton.onClick.AddListener(onClickBackButton);
        }
    }
}
