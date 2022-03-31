using UnityEngine;

public class CharacterData {
   private int strength;
   private int dextirity;
   private int con;
   private int intel;

   private CharacterView view;

   public CharacterData(int strength = 3, int dextirity = 3, int con = 3, int intel = 3) {
      this.strength = strength;
      this.dextirity = dextirity;
      this.con = con;
      this.intel = intel;
   }
}
