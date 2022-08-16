using Agate.MVC.Base;
using SpaceInvader.Module.Input;
using SpaceInvader.Module.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Player{
    public class PlayerController : ObjectController<PlayerController, PlayerModel, IPlayerModel, PlayerView>
    {

        /*public void OnMovePlayer()
        {
            if (Input.GetKey(_view.inputLeft) && _view.transform.position.x > _model.maxLeft)
            {
                _view.transform.Translate(_model.speed * Time.deltaTime * Vector2.left);
            }
            if (Input.GetKey(_view.inputRight) && _view.transform.position.x < _model.maxRight)
            {
               _view.transform.Translate(_model.speed * Time.deltaTime * Vector2.right);
            }

        }

        public override void SetView(PlayerView view)
        {
            base.SetView(view);
            view.SetCallBacks(OnMovePlayer);
        }*/

        public void OnMovePlayer(Vector2 message)
        {
            _model.SetDirection(message);
        }
    }
}