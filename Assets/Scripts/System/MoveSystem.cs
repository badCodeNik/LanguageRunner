using CoreInfo;
using Exerussus._1EasyEcs.Scripts.Core;
using Leopotam.EcsLite;
using UnityEngine;

namespace System
{
    public class MoveSystem : EasySystem<CorePooler>
    {
        private EcsFilter _moveFilter;

        protected override void Initialize()
        {
            _moveFilter = World.Filter<CoreData.MoveData>().End();
        }

        protected override void Update()
        {
            foreach (var entity in _moveFilter)
            {
                ref var transformData = ref Pooler.TransformData.Get(entity);
                ref var moveData = ref Pooler.MoveData.Get(entity);
                if (Pooler.BoostSpeedData.Has(entity))
                {
                    ref var speedData = ref Pooler.BoostSpeedData.Get(entity);
                    speedData.Timer += DeltaTime;
                    var totalSpeed = speedData.IsCorrect
                        ? speedData.BoostSpeed + moveData.Speed
                        : moveData.Speed - speedData.BoostSpeed;
                    
                    transformData.Value.position += Vector3.forward * totalSpeed * DeltaTime;
                    if (speedData.Timer >= speedData.BoostTime)
                    {
                        Pooler.BoostSpeedData.Del(entity);
                    }
                }
                else
                {
                    transformData.Value.position += Vector3.forward * moveData.Speed * DeltaTime;
                }
            }
        }
    }
}