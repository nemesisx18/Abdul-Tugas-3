using Agate.MVC.Base;
using SpaceInvader.Module.Enemy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Scene.Gameplay
{
	public class GameplayView : BaseSceneView
	{
		[SerializeField] EnemySpawnerView enemySpawnerView;

		public EnemySpawnerView EnemySpawnerView => enemySpawnerView;
	}
}
