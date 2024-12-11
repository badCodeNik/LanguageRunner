// using CoreInfo;
// using Exerussus._1EasyEcs.Scripts.Core;
// using Leopotam.EcsLite;
// using UnityEngine;
//
// namespace System
// {
//     public class InputSystem : EasySystem<CorePooler>
//     {
//         private InputActions _input;
//         private Vector2 _startPosition;
//         private Vector2 _endPosition;
//         private float _startTime;
//         private float _endTime;
//         private float _swipeThreshold = 2f;
//         private float _minimumTime = .2f;
//
//
//         protected override void Initialize()
//         {
//             _input = new InputActions();
//             _input.Enable();
//             _input.RunnerController.PrimaryContact.started += StartTouchPrimary;
//             _input.RunnerController.PrimaryContact.canceled += EndTouchPrimary;
//         }
//
//         private void StartTouchPrimary(InputAction.CallbackContext context)
//         {
//             _startPosition = ScreenToWorld(_input.RunnerController.PrimaryPosition.ReadValue<Vector2>());
//             _startTime = (float)context.time;
//         }
//
//         private void EndTouchPrimary(InputAction.CallbackContext context)
//         {
//             _endPosition = ScreenToWorld(_input.RunnerController.PrimaryPosition.ReadValue<Vector2>());
//             _endTime = (float)context.time;
//             DetectSwipe();
//         }
//
//         private void DetectSwipe()
//         {
//             var direction = _endPosition - _startPosition;
//
//             if (direction.x > 0) Signal.RegistryRaise(new CoreSignals.OnSwipeRight());
//             else Signal.RegistryRaise(new CoreSignals.OnSwipeLeft());
//         }
//
//
//         public override void Destroy(IEcsSystems systems)
//         {
//             _input.Disable();
//             _input.RunnerController.PrimaryContact.started -= StartTouchPrimary;
//             _input.RunnerController.PrimaryContact.canceled -= EndTouchPrimary;
//         }
//
//         private Vector3 ScreenToWorld(Vector2 position)
//         {
//             return Camera.main.ScreenToWorldPoint(position);
//         }
//     }
// }