using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Module.Message;

namespace SpaceInvader.Module.Enemy
{
    public class EnemyController : ObjectController<EnemyController, EnemyModel, IEnemyModel, EnemyView>
    {
        public void OnDead()
        {
            Publish<StartPlayMessage>(new StartPlayMessage());
        }
        
        public override void SetView(EnemyView view)
        {
            base.SetView(view);
            view.SetCallback(OnDead);
        }

        public void Init(EnemyModel model, EnemyView view)
        {
            _model = model;
            SetView(view);
        }

        public override IEnumerator Finalize()
        {
            return base.Finalize();
            
        }
    }
}