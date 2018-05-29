public class WaterElemental : Minion {

	public WaterElemental(){
		maxHealth = 6;
		health = 6;
		attack = 3;
		manaCost = 4;
		name = "water elemental";
	}

	public override void play(ref Player p){
		base.play (ref p);
	}

	public override void hit(ref Entity other){
		base.hit (ref other);
		other.abilityList.Add (new Freeze ());
	}

	public override void die(){

	}
}
