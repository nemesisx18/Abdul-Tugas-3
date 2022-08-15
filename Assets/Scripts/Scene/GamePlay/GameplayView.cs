using Agate.MVC.Base;
using SpaceInvader.Module.Player;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Scene.Gameplay
{
	public class GameplayView : BaseSceneView
	{
		[SerializeField] public PlayerView PlayerView;
	}
}
