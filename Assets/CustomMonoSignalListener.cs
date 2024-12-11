using Exerussus._1Extensions.SignalSystem;
using UnityEngine;

namespace Source.Scripts.Client.MonoBehaviours
{
    public abstract class CustomMonoSignalListener : MonoBehaviour
    {
        public Signal Signal => DependenciesContainer.SignalHandler.Signal;
        
    }

    public abstract class CustomMonoSignalListener<T1> : CustomMonoSignalListener 
        where T1 : struct
    {
        protected virtual void OnEnable()
        {
            Signal.Subscribe<T1>(OnSignal);
        }

        protected virtual void OnDisable()
        {
            Signal.Unsubscribe<T1>(OnSignal);
        }

        protected abstract void OnSignal(T1 data);
    }

    public abstract class CustomMonoSignalListener<T1, T2> : CustomMonoSignalListener
        where T1 : struct  
        where T2 : struct
    {
        protected virtual void OnEnable()
        {
            Signal.Subscribe<T1>(OnSignal);
            Signal.Subscribe<T2>(OnSignal);
        }

        protected virtual void OnDisable()
        {
            Signal.Unsubscribe<T1>(OnSignal);
            Signal.Unsubscribe<T2>(OnSignal);
        }

        protected abstract void OnSignal(T1 data);
        protected abstract void OnSignal(T2 data);
    }

    public abstract class CustomMonoSignalListener<T1, T2, T3> : CustomMonoSignalListener
        where T1 : struct  
        where T2 : struct
        where T3 : struct
    {
        protected virtual void OnEnable()
        {
            Signal.Subscribe<T1>(OnSignal);
            Signal.Subscribe<T2>(OnSignal);
            Signal.Subscribe<T3>(OnSignal);
        }

        protected virtual void OnDisable()
        {
            Signal.Unsubscribe<T1>(OnSignal);
            Signal.Unsubscribe<T2>(OnSignal);
            Signal.Unsubscribe<T3>(OnSignal);
        }

        protected abstract void OnSignal(T1 data);
        protected abstract void OnSignal(T2 data);
        protected abstract void OnSignal(T3 data);
    }

    public abstract class CustomMonoSignalListener<T1, T2, T3, T4> : CustomMonoSignalListener
        where T1 : struct  
        where T2 : struct
        where T3 : struct
        where T4 : struct
    {
        protected virtual void OnEnable()
        {
            Signal.Subscribe<T1>(OnSignal);
            Signal.Subscribe<T2>(OnSignal);
            Signal.Subscribe<T3>(OnSignal);
            Signal.Subscribe<T4>(OnSignal);
        }

        protected virtual void OnDisable()
        {
            Signal.Unsubscribe<T1>(OnSignal);
            Signal.Unsubscribe<T2>(OnSignal);
            Signal.Unsubscribe<T3>(OnSignal);
            Signal.Unsubscribe<T4>(OnSignal);
        }

        protected abstract void OnSignal(T1 data);
        protected abstract void OnSignal(T2 data);
        protected abstract void OnSignal(T3 data);
        protected abstract void OnSignal(T4 data);
    }

    public abstract class CustomMonoSignalListener<T1, T2, T3, T4, T5> : CustomMonoSignalListener
        where T1 : struct  
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
    {
        protected virtual void OnEnable()
        {
            Signal.Subscribe<T1>(OnSignal);
            Signal.Subscribe<T2>(OnSignal);
            Signal.Subscribe<T3>(OnSignal);
            Signal.Subscribe<T4>(OnSignal);
            Signal.Subscribe<T5>(OnSignal);
        }

        protected virtual void OnDisable()
        {
            Signal.Unsubscribe<T1>(OnSignal);
            Signal.Unsubscribe<T2>(OnSignal);
            Signal.Unsubscribe<T3>(OnSignal);
            Signal.Unsubscribe<T4>(OnSignal);
            Signal.Unsubscribe<T5>(OnSignal);
        }

        protected abstract void OnSignal(T1 data);
        protected abstract void OnSignal(T2 data);
        protected abstract void OnSignal(T3 data);
        protected abstract void OnSignal(T4 data);
        protected abstract void OnSignal(T5 data);
    }

    public abstract class CustomMonoSignalListener<T1, T2, T3, T4, T5, T6> : CustomMonoSignalListener
        where T1 : struct  
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
    {
        protected virtual void OnEnable()
        {
            Signal.Subscribe<T1>(OnSignal);
            Signal.Subscribe<T2>(OnSignal);
            Signal.Subscribe<T3>(OnSignal);
            Signal.Subscribe<T4>(OnSignal);
            Signal.Subscribe<T5>(OnSignal);
            Signal.Subscribe<T6>(OnSignal);
        }

        protected virtual void OnDisable()
        {
            Signal.Unsubscribe<T1>(OnSignal);
            Signal.Unsubscribe<T2>(OnSignal);
            Signal.Unsubscribe<T3>(OnSignal);
            Signal.Unsubscribe<T4>(OnSignal);
            Signal.Unsubscribe<T5>(OnSignal);
            Signal.Unsubscribe<T6>(OnSignal);
        }

        protected abstract void OnSignal(T1 data);
        protected abstract void OnSignal(T2 data);
        protected abstract void OnSignal(T3 data);
        protected abstract void OnSignal(T4 data);
        protected abstract void OnSignal(T5 data);
        protected abstract void OnSignal(T6 data);
    }

    public abstract class CustomMonoSignalListener<T1, T2, T3, T4, T5, T6, T7> : CustomMonoSignalListener
        where T1 : struct  
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
    {
        protected virtual void OnEnable()
        {
            Signal.Subscribe<T1>(OnSignal);
            Signal.Subscribe<T2>(OnSignal);
            Signal.Subscribe<T3>(OnSignal);
            Signal.Subscribe<T4>(OnSignal);
            Signal.Subscribe<T5>(OnSignal);
            Signal.Subscribe<T6>(OnSignal);
            Signal.Subscribe<T7>(OnSignal);
        }

        protected virtual void OnDisable()
        {
            Signal.Unsubscribe<T1>(OnSignal);
            Signal.Unsubscribe<T2>(OnSignal);
            Signal.Unsubscribe<T3>(OnSignal);
            Signal.Unsubscribe<T4>(OnSignal);
            Signal.Unsubscribe<T5>(OnSignal);
            Signal.Unsubscribe<T6>(OnSignal);
            Signal.Unsubscribe<T7>(OnSignal);
        }

        protected abstract void OnSignal(T1 data);
        protected abstract void OnSignal(T2 data);
        protected abstract void OnSignal(T3 data);
        protected abstract void OnSignal(T4 data);
        protected abstract void OnSignal(T5 data);
        protected abstract void OnSignal(T6 data);
        protected abstract void OnSignal(T7 data);
    }

    public abstract class CustomMonoSignalListener<T1, T2, T3, T4, T5, T6, T7, T8> : CustomMonoSignalListener
        where T1 : struct  
        where T2 : struct
        where T3 : struct
        where T4 : struct
        where T5 : struct
        where T6 : struct
        where T7 : struct
        where T8 : struct
    {
        protected virtual void OnEnable()
        {
            Signal.Subscribe<T1>(OnSignal);
            Signal.Subscribe<T2>(OnSignal);
            Signal.Subscribe<T3>(OnSignal);
            Signal.Subscribe<T4>(OnSignal);
            Signal.Subscribe<T5>(OnSignal);
            Signal.Subscribe<T6>(OnSignal);
            Signal.Subscribe<T7>(OnSignal);
            Signal.Subscribe<T8>(OnSignal);
        }

        protected virtual void OnDisable()
        {
            Signal.Unsubscribe<T1>(OnSignal);
            Signal.Unsubscribe<T2>(OnSignal);
            Signal.Unsubscribe<T3>(OnSignal);
            Signal.Unsubscribe<T4>(OnSignal);
            Signal.Unsubscribe<T5>(OnSignal);
            Signal.Unsubscribe<T6>(OnSignal);
            Signal.Unsubscribe<T7>(OnSignal);
            Signal.Unsubscribe<T8>(OnSignal);
        }

        protected abstract void OnSignal(T1 data);
        protected abstract void OnSignal(T2 data);
        protected abstract void OnSignal(T3 data);
        protected abstract void OnSignal(T4 data);
        protected abstract void OnSignal(T5 data);
        protected abstract void OnSignal(T6 data);
        protected abstract void OnSignal(T7 data);
        protected abstract void OnSignal(T8 data);
    }
}