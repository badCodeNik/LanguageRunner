using Exerussus._1Extensions.Abstractions;
using GoogleImporter;
using UnityEngine;

namespace Source.Scripts.Client.MonoBehaviours.Storages
{
    [CreateAssetMenu(fileName = "GameStorage", menuName = "Data/GameStorage")]
    public class GameStorage : ScriptableObject,IInitializable
    {
        public Config config;
        public void Initialize() { }
    }
}