using System;
using CoreInfo;
using Exerussus._1Extensions.SignalSystem;
using UnityEngine;

namespace Monobehaviours
{
    [RequireComponent(typeof(Collider))]
    public class Hero : MonoBehaviour
    {
        private Signal _signal;
        private Collider _collider;

        public void Initialize(Signal signal)
        {
            _signal = signal;
        }

        private void OnTriggerEnter(Collider other)
        {
            _signal.RegistryRaise(new CoreSignals.OnTriggerEntered());
        }

        private void OnValidate()
        {
            if (_collider == null) _collider = GetComponent<Collider>();
        }
    }
}