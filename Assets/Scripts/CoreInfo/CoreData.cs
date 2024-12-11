using Exerussus._1EasyEcs.Scripts.Core;
using UnityEngine;

namespace CoreInfo
{
    public class CoreData
    {
        public struct ViewHandler : IEcsComponent
        {
            public GameObject View;
        }

        public struct TransformData : IEcsComponent
        {
            public Transform Value;
        }

        public struct MoveData : IEcsComponent
        {
            public float Speed;
        }

        public struct CameraData : IEcsComponent
        {
            public Camera Value;
        }

        public struct BoostSpeedData : IEcsComponent
        {
            public bool IsCorrect;
            public float BoostSpeed;
            public float BoostTime;
            public float Timer;
        }
    }
}