using System;
using CoreInfo;
using Exerussus._1EasyEcs.Scripts.Core;
using Exerussus._1EasyEcs.Scripts.Custom;
using Exerussus._1Extensions.Loader;
using Exerussus._1Extensions.SignalSystem;
using GoogleImporter;
using Leopotam.EcsLite;
using UnityEngine;

namespace Core
{
    public class EcsStarter : Exerussus._1EasyEcs.Scripts.Custom.EcsStarter
    {
        protected override GameContext GetGameContext(GameShare gameShare)
        {
            return new GameContext();
        }

        public override void Initialize()
        {
            base.Initialize();
            ConfigImportsMenu.LoadSheetsSettings();
        }

        protected override EcsGroup[] GetGroups()
        {
            return new EcsGroup[]
            {
                new CoreGroup()
            };
        }

        protected override void SetSharingDataOnStart(EcsWorld world, GameShare gameShare)
        {
            gameShare.AddSharedObject(new ResourceLoader());
            gameShare.AddSharedObject(Signal);
        }


        protected override Func<float> FixedUpdateDelta { get; } = () => Time.fixedDeltaTime;

        protected override Func<float> UpdateDelta { get; } = () => Time.deltaTime;

        protected override Signal Signal => signalHandler.Signal;

        [SerializeField] private SignalHandler signalHandler;
    }
}