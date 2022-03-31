using Entitas;
using UnityEngine;

public class LeftClickSystem : IExecuteSystem {
   private Camera mainCam;
   
   public LeftClickSystem(Contexts contexts) {
      mainCam = Camera.main;
   }
   
   public void Execute() {
      if (Input.GetMouseButton(0)) {
         
      }
   }
}
