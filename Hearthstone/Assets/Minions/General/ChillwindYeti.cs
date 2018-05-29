public class ChillwindYeti : Minion {
	public ChillwindYeti(){
		maxHealth = 5;
		health = 5;
		attack = 4;
		manaCost = 4;
		name = "chillwind yeti";
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
