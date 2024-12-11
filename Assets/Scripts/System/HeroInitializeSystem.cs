using CoreInfo;
using Exerussus._1EasyEcs.Scripts.Core;
using Exerussus._1Extensions.Loader;
using Monobehaviours;
using UnityEngine;

namespace System
{
    public class HeroInitializeSystem : EasySystem<CorePooler>
    {
        private ResourceLoader _resourceLoader;

        protected override void Initialize()
        {
            var entity = World.NewEntity();
            ref var viewHandler = ref Pooler.ViewHandler.AddOrGet(entity);
            ref var transformData = ref Pooler.TransformData.AddOrGet(entity);
            ref var moveData = ref Pooler.MoveData.AddOrGet(entity);
            ref var cameraData = ref Pooler.CameraData.AddOrGet(entity);
            moveData.Speed = 5;
            GameShare.GetSharedObject(ref _resourceLoader);
            viewHandler.View = InstantiateHero();
            cameraData.Value = Camera.main;
            cameraData.Value.transform.SetParent(viewHandler.View.transform);
            transformData.Value = viewHandler.View.transform;
        }


        private GameObject InstantiateHero()
        {
            var prefab = _resourceLoader.ResourceLoad<GameObject>("Prefabs/Character");
            var hero = UnityEngine.Object.Instantiate(prefab);
            hero.AddComponent<Hero>().Initialize(Signal);
            return hero;
        }
    }
}