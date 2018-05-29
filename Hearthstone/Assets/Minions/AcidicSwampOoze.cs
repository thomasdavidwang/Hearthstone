using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcidicSwampOoze : Minion {

	public AcidicSwampOoze(){

	}

	public override void play(Player p){
		p.opponent.breakWeapon();
	}

	public override void die(){

	}
}
