using System.Collections;
using UnityEngine;

public interface IRoutineRunner {
    Coroutine StartCr(IEnumerator method);
    void StopCr(Coroutine coroutine);
    void StopAllCr();
}

public class RoutineRunner : MonoBehaviour, IRoutineRunner {
    void Start() {
        
        
    }

    void Update() {
        
    }

    public Coroutine StartCr(IEnumerator method) {
        return StartCoroutine(method);
    }

    public void StopCr(Coroutine coroutine) {
        StopCoroutine(coroutine);
    }

    public void StopAllCr() {
        StopAllCoroutines();
    }
}
