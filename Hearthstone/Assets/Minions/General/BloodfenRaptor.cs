public class BloodfenRaptor : Minion {

	public BloodfenRaptor(){
		maxHealth = 2;
		health = 2;
		attack = 3;
		manaCost = 2;
		tribe = "beast";
		name = "bloodfen raptor";
	}

	public override void play(ref Player p){
		base.play (ref p);
	}

	public override void hit(ref Entity other){
		base.hit (ref other);
	}

	public override void die(){

	}
}
