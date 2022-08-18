using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace SpaceInvader.Module.HUD
{
    public class HUDView : ObjectView<IHUDModel>
    {
        [SerializeField]
        private Text _healthText;

        protected override void InitRenderModel(IHUDModel model)
        {
            _healthText.text = $"Health: {model.Health}";
        }

        protected override void UpdateRenderModel(IHUDModel model)
        {
            _healthText.text = $"Health: {model.Health}";
        }
    }
}