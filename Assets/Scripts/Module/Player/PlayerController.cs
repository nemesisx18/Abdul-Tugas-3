using Agate.MVC.Base;
using SpaceInvader.Module.Input;
using SpaceInvader.Module.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Player{
    public class PlayerController : ObjectController<PlayerController, PlayerModel, IPlayerModel, PlayerView>
    {
        public void OnMovePlayer(float x)
        {
            Vector2 dir = new Vector2(x, 0);
            _model.SetDirection(dir);
        }

        public void OnShoot()
        {
            Vector2 pos = _view.transform.position;

            Publish<SpawnBulletMessage>(new SpawnBulletMessage(pos));
        }

        public override void SetView(PlayerView view)
        {
            base.SetView(view);
            view.SetCallbacks(OnCollideWithEnemyBullet);
        }

        private void OnCollideWithEnemyBullet()
        {
            Debug.Log("Tertembak");
        }
    }
}