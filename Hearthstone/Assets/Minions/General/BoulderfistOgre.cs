public class BoulderfistOgre : Minion {
	public BoulderfistOgre(){
		maxHealth = 7;
		health = 7;
		attack = 6;
		manaCost = 6;
		name = "boulderfist ogre";
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
