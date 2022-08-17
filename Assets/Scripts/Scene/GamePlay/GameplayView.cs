using Agate.MVC.Base;
using SpaceInvader.Module.Enemy;
using SpaceInvader.Module.Bullet;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Scene.Gameplay
{
	public class GameplayView : BaseSceneView
	{
		[SerializeField] EnemySpawnerView enemySpawnerView;
		[SerializeField] BulletPoolView bulletPoolView;

		public EnemySpawnerView EnemySpawnerView => enemySpawnerView;

		public BulletPoolView BulletPoolView => bulletPoolView;
	}
}
