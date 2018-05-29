public class RiverCrocolisk : Minion {
	public RiverCrocolisk(){
		maxHealth = 3;
		health = 3;
		attack = 2;
		manaCost = 2;
		tribe = "beast";
		name = "river crocolisk";
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
