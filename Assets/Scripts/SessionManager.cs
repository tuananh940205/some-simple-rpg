using System;
using UnityEngine;

public class SessionManager : MonoBehaviour {
    void Awake() {
        ServiceLocator.Instance.RegisterSingleton(this);
        DontDestroyOnLoad(this);
    }

    private void Start() {
        ServiceLocator.Instance.RegisterSingleton<IRoutineRunner>(GetComponent<RoutineRunner>());
    }

    void Update() {
        
    }
}
