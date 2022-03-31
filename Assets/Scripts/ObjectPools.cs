using System;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPools : MonoBehaviour {
    void Start() {
        ServiceLocator.Instance.RegisterSingleton(this);
    }

    private void OnDestroy() {
        ServiceLocator.Instance.UnregisterSingleton(this);
    }

    public void Spawn() {
    }
}
