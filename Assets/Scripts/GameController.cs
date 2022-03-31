using Entitas;
using UnityEngine;

public class GameController : MonoBehaviour {
    private Systems systems;
    
    void Start() {
        Contexts contexts = Contexts.sharedInstance;
        systems = new Feature("Total Systems")
            .Add(new InputSystems(contexts));
        systems.Initialize();
    }

    void Update() {
        systems.Execute();
        systems.Cleanup();
    }
}
