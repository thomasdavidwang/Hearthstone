public class StonetuskBoar : Minion {
	public StonetuskBoar(){
		maxHealth = 1;
		health = 1;
		attack = 1;
		manaCost = 1;
		tribe = "beast";
		name = "stonetusk boar";
	}

	public override void play(ref Player p){
		base.play (ref p);
		canAttack++;
	}

	public override void hit(ref Entity other){
		base.hit (ref other);
	}

	public override void die(){

	}
}
