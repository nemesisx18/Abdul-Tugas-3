using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Shield
{
    public class ShieldController : ObjectController<ShieldController, ShieldModel, IShieldModel, ShieldView>
    {
        public override void SetView(ShieldView view)
        {
            base.SetView(view);
            view.SetCallbacks(HitEnemyBullet);
        }

        private void HitEnemyBullet()
        {
            _model.DamagedShield();
            Debug.Log("Tertembak");
        }
    }
}