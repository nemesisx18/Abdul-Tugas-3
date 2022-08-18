using Agate.MVC.Base;
using SpaceInvader.Module.Player;
using SpaceInvader.Module.Enemy;
using SpaceInvader.Module.Bullet;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpaceInvader.Module.HUD;
using SpaceInvader.Module.GameOver;

namespace SpaceInvader.Scene.Gameplay
{
	public class GameplayView : BaseSceneView
	{
		[SerializeField] public HUDView HUDView;
		[SerializeField] public GameOverView GameOverView;
		[SerializeField] EnemySpawnerView enemySpawnerView;
		[SerializeField] BulletPoolView bulletPoolView;
		[SerializeField] PlayerView playerView;

		public EnemySpawnerView EnemySpawnerView => enemySpawnerView;

		public BulletPoolView BulletPoolView => bulletPoolView;

		public PlayerView PlayerView => playerView;
	}
}
