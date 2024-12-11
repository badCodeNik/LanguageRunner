using Exerussus._1EasyEcs.Scripts.Core;
using Exerussus._1EasyEcs.Scripts.Custom;
using Leopotam.EcsLite;

namespace CoreInfo
{
    public class CorePooler : IGroupPooler
    {
        public PoolerModule<CoreData.ViewHandler> ViewHandler { get; private set; }
        public PoolerModule<CoreData.TransformData> TransformData { get; private set; }
        public PoolerModule<CoreData.MoveData> MoveData { get; private set; }
        public PoolerModule<CoreData.CameraData> CameraData { get; private set; }
        public PoolerModule<CoreData.BoostSpeedData> BoostSpeedData { get; private set; }

        public void Initialize(EcsWorld world)
        {
            ViewHandler = new PoolerModule<CoreData.ViewHandler>(world);
            TransformData = new PoolerModule<CoreData.TransformData>(world);
            MoveData = new PoolerModule<CoreData.MoveData>(world);
            CameraData = new PoolerModule<CoreData.CameraData>(world);
            BoostSpeedData = new PoolerModule<CoreData.BoostSpeedData>(world);
        }
    }
}