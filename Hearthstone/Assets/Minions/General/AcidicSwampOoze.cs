public class AcidicSwampOoze : Minion {

	public AcidicSwampOoze(){
		maxHealth = 2;
		health = 2;
		attack = 3;
		manaCost = 2;
		name = "acidic swamp ooze";
	}

	public override void play(ref Player p){
		p.opponent.breakWeapon();
		base.play (ref p);
	}

	public override void die(){

	}
}
