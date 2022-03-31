using System;
using System.Collections.Generic;
using UnityEngine;

public class ServiceLocator {
   private static ServiceLocator _instance;
   private readonly Dictionary<Type, object> _singletonInstances;

   public static ServiceLocator Instance => _instance ??= new ServiceLocator();

   private ServiceLocator() {
      _singletonInstances = new Dictionary<Type, object>();
   }

   public void RegisterSingleton(object ins) {
      var type = ins.GetType();

      if (_singletonInstances.ContainsKey(type)) {
         Debug.LogError($"");
         return;
      }

      _singletonInstances[type] = ins;
   }

   public void RegisterSingleton<T>(object ins) {
      _singletonInstances[typeof(T)] = ins;
   }

   public void UnregisterSingleton(object ins) {
      var type = ins.GetType();
      if (_singletonInstances.ContainsKey(type)) {
         _singletonInstances.Remove(type);
      }
   }

   public T Resolved<T>() {
      if (!_singletonInstances.TryGetValue(typeof(T), out object ins)) {
         if (typeof(T).IsSubclassOf(typeof(BaseSignal))) {
            ins = Activator.CreateInstance<T>();
            RegisterSingleton(ins);
            return (T) ins;
         }
      }

      if (ins is T result)
         return result;

      if (ins == null)
         return default;
      
      Debug.LogError($"Wrong data type {ins.GetType()}");
      return default;
   }
}
