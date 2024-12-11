using System.Collections.Generic;
using System.Linq;
using Exerussus._1Extensions.Abstractions;
using Exerussus._1Extensions.ProjectLoader.Loaders;
using Exerussus._1Extensions.SignalSystem;
using Source.Scripts.Client.MonoBehaviours.Storages;
using UnityEditor;
using UnityEngine;

/// <summary>
/// Контейнер для всех конфигов и библиотек.
/// </summary>
public static class DependenciesContainer
{
    
    private static SignalHandler _signalHandler = GetAsset<SignalHandler>(Constants.Constants.Configs.AssetPath.SignalHandler);
    private static GameStorage _gameStorage = GetAsset<GameStorage>(Constants.Constants.Configs.AssetPath.GameStorage);

    private static ConfigHub _configHub = Initialize();

    public static SignalHandler SignalHandler => _signalHandler;
    public static GameStorage GameStorage => _gameStorage;
    
    public static IInitializable[] AllConfigs { get; private set; }
    
    private static ConfigHub Initialize()
    {
        _configHub = Resources.Load<ConfigHub>(Constants.Constants.Configs.AssetPath.ConfigHub);
        
        AllConfigs = new InitializeBuilder(_configHub)

            .Add(ref _signalHandler)
            .Add(ref _gameStorage)
            .End();
        
        return _configHub;
    }
    
    private static T GetAsset<T>(string path) where T : ScriptableObject
    {
#if UNITY_EDITOR
        return AssetDatabase.LoadAssetAtPath<T>(path);
#else
        return null;
#endif
    }
    
    private static T GetLibrary<T>(string path) where T : ScriptableObject, IInitializable
    {
#if UNITY_EDITOR
        var library = AssetDatabase.LoadAssetAtPath<T>(path);
        library.Initialize();
        return library;
#else
        return null;
#endif
    }

    public class InitializeBuilder
    {
        private ConfigHub _configHub;
        private HashSet<IInitializable> _libraries;

        public InitializeBuilder(ConfigHub configHub)
        {
            StartCreate(configHub);
        }

        private InitializeBuilder StartCreate(ConfigHub configHub)
        {
            _configHub = configHub;
            _libraries = new();
            return this;
        }

        public InitializeBuilder Add<T>(ref T config) where T : ScriptableObject, IInitializable
        {
            if (config as T == null)
            {
                config = _configHub.GetConfig<T>();
                _libraries.Add(config);
            }
            return this;
        }

        public IInitializable[] End()
        {
            foreach (var library in _libraries)
            {
                library.Initialize();
            }

            return _libraries.ToArray();
        }
    }
}
