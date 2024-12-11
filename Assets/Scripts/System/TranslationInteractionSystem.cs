using CoreInfo;
using Exerussus._1EasyEcs.Scripts.Core;
using Leopotam.EcsLite;

namespace System
{
    public class TranslationInteractionSystem : EcsSignalListener<CorePooler, CoreSignals.OnTranslationChosen>
    {
        private EcsFilter _playerFilter;

        protected override void Initialize()
        {
            _playerFilter = World.Filter<CoreData.CameraData>().End();
        }

        protected override void OnSignal(CoreSignals.OnTranslationChosen data)
        {
            ref var speedBoost = ref Pooler.BoostSpeedData.Add(_playerFilter.GetFirstEntity());
            speedBoost.IsCorrect = data.RightAnswer == data.ChosenTranslation;
            speedBoost.BoostSpeed = 2f;
            speedBoost.BoostTime = 2f;
        }

        protected override void Update()
        {
        }
    }
}