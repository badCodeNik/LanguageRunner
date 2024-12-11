using System;
using Exerussus._1EasyEcs.Scripts.Custom;
using Leopotam.EcsLite;

namespace CoreInfo
{
    public class CoreGroup : EcsGroup<CorePooler>
    {
        protected override void SetInitSystems(IEcsSystems initSystems)
        {
            initSystems.Add(new HeroInitializeSystem());
        }

        protected override void SetFixedUpdateSystems(IEcsSystems fixedUpdateSystems)
        {
            fixedUpdateSystems.Add(new Leopotam.EcsLite.UnityEditor.EcsWorldDebugSystem());
        }

        protected override void SetUpdateSystems(IEcsSystems updateSystems)
        {
            updateSystems.Add(new MoveSystem());
            updateSystems.Add(new TranslationInteractionSystem());
        }

        protected override void SetLateUpdateSystems(IEcsSystems lateUpdateSystems)
        {
        }

        protected override void SetTickUpdateSystems(IEcsSystems tickUpdateSystems)
        {
        }
    }
}