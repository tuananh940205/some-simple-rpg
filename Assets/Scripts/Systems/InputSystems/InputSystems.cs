using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSystems : Feature {
   public InputSystems(Contexts contexts) : base ("Input Systems") {
      Add(new LeftClickSystem(contexts));
   }
}
