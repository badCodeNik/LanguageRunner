using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Source.Scripts.Client.MonoBehaviours.Extensions
{
    public static class DictionaryExtensions
    {
        public static KeyValuePair<TKey, TValue> PopRandom<TKey, TValue>(this Dictionary<TKey, TValue> dictionary)
        {
#if UNITY_EDITOR
            if (dictionary.Count == 0) 
                Debug.LogError("Пустой словарь");
#endif
            if (dictionary.Count == 1)
            {
                var singleEntry = new KeyValuePair<TKey, TValue>(dictionary.Keys.First(), dictionary.Values.First());
                dictionary.Clear(); // Очищаем словарь
                return singleEntry; // Возвращаем единственную пару
            }

            // Получаем случайный индекс
            var randomIndex = UnityEngine.Random.Range(0, dictionary.Count);
        
            // Находим ключ по индексу
            var key = new List<TKey>(dictionary.Keys)[randomIndex];
        
            // Получаем значение по ключу и удаляем его из словаря
            var value = dictionary[key];
            dictionary.Remove(key);
        
            return new KeyValuePair<TKey, TValue>(key, value);
        }
    }
}