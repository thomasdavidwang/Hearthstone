public class Boar : Minion {
	public Boar(){
		maxHealth = 1;
		health = 1;
		attack = 1;
		manaCost = 1;
		tribe = "beast";
		name = "boar";
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
