using Agate.MVC.Base;
using SpaceInvader.Module.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

namespace SpaceInvader.Module.Input
{
    public class InputController : BaseController<InputController>
    {
        private InputActionManager _inputActionsManager = new InputActionManager();

        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            _inputActionsManager.Input.Move.performed += OnClick;
        }

        private void OnClick(InputAction.CallbackContext context)
        {
            bool isOverUI = EventSystem.current.IsPointerOverGameObject();
            if(context.performed && !isOverUI)
            {
                Publish<MovePlayerMessage>(new MovePlayerMessage());
            }
        }
    }
}
