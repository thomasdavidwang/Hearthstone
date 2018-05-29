public class OasisSnapjaw : Minion {
	public OasisSnapjaw(){
		maxHealth = 7;
		health = 7;
		attack = 2;
		manaCost = 4;
		tribe = "beast";
		name = "oasis snapjaw";
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
