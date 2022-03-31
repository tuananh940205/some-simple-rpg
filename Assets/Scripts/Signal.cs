using System;

public interface ISignal {
}

public interface IPool {
   
}

public class BaseSignal : ISignal { }

public class Signal : BaseSignal {
   private event Action listeners;

   public void AddListener(Action action) {
      listeners -= action;
      listeners += action;
   }

   public void Dispatch() {
      listeners?.Invoke();
   }

   public void RemoveListener(Action action) {
      listeners -= action;
   }

   public void RemoveAllListener() {
      listeners = null;
   }
}

public class Signal<T> : BaseSignal {
   private event Action<T> listeners;

   public void AddListener(Action<T> action) {
      listeners -= action;
      listeners += action;
   }

   public void Dispatch(T val) {
      listeners?.Invoke(val);
   }

   public void RemoveListener(Action<T> action) {
      listeners -= action;
   }

   public void RemoveAllListeners() {
      listeners = null;
   }
}

public class Signal<T, U> : BaseSignal {
   private event Action<T, U> listeners;
   
   public void AddListener(Action<T, U> action) {
      listeners -= action;
      listeners += action;
   }

   public void Dispatch(T val, U val2) {
      listeners?.Invoke(val, val2);
   }

   public void RemoveListener(Action<T, U> action) {
      listeners -= action;
   }

   public void RemoveAllListeners() {
      listeners = null;
   }
}