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

namespace SpaceInvader.Scene.Gameplay
{
	public class GameplayView : BaseSceneView
	{
		[SerializeField] HUDView hudView;
		[SerializeField] GameOverView gameOverView;
		[SerializeField] EnemySpawnerView enemySpawnerView;
		[SerializeField] BulletPoolView bulletPoolView;
		[SerializeField] PlayerView playerView;
		[SerializeField] ShieldView shieldView;

		public EnemySpawnerView EnemySpawnerView => enemySpawnerView;

		public BulletPoolView BulletPoolView => bulletPoolView;

		public PlayerView PlayerView => playerView;

		public HUDView HUDView => hudView;

		public GameOverView GameOverView => gameOverView;

		public ShieldView ShieldView => shieldView;
	}
}
