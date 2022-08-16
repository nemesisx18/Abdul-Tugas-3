using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Enemy
{
    public class EnemyController : ObjectController<EnemyController, EnemyModel, IEnemyModel, EnemyView>
    {
        public void MoveEnemy()
        {
            Debug.Log("movee");
            
            _model.walkAmount = new Vector2(_model.walkDirection * 0.5f * Time.deltaTime, 0);

            if (_model.walkDirection > 0.0f && _view.transform.position.x >= _model.originalX + 0.5)
            {
                _model.walkDirection = -1.0f;
                _view.transform.position = new Vector3(_view.transform.position.x,
                    _view.transform.position.y - 1, _view.transform.position.z);
            }
            else if (_model.walkDirection < 0.0f && _view.transform.transform.position.x <= _model.originalX - 0.75)
            {
                _model.walkDirection = 1.0f;
                _view.transform.position = new Vector3(_view.transform.position.x,
                    _view.transform.position.y - 1, _view.transform.position.z);
            }

            _view.transform.Translate(_model.walkAmount);
        }

        public override void SetView(EnemyView view)
        {
            base.SetView(view);
            view.SetCallback(MoveEnemy);
        }

        public void Init(EnemyModel model, EnemyView view)
        {
            _model = model;
            SetView(view);
        }
    }
}