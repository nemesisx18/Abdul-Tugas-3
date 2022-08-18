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
            _inputActionsManager.Input.Enable();
            _inputActionsManager.Input.Move.performed += OnMoveSpace;
            _inputActionsManager.Input.Shoot.performed += OnShootSpace;
        }

        private void OnMoveSpace(InputAction.CallbackContext context)
        {
            Publish<MovePlayerMessage>(new MovePlayerMessage(context.ReadValue<float>()));
        }

        private void OnShootSpace(InputAction.CallbackContext context)
        {
            Publish<ShootBulletPlayerMessage>(new ShootBulletPlayerMessage());
        }

        public override IEnumerator Terminate()
        {
            _inputActionsManager.Input.Disable();
            return base.Terminate();
        }
    }
}
