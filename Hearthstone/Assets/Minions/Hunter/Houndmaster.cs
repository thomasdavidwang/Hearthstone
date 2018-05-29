public class Houndmaster : Minion {
	public Houndmaster(){
		maxHealth = 3;
		health = 3;
		attack = 4;
		manaCost = 4;
		name = "houndmaster";
	}

	public void play(ref Minion m, ref Player p){
		if (m.tribe == "beast") {
			m.attack = m.attack + 2;
			m.health = m.health + 2;
		}
		base.play (ref p);
	}

	public override void hit(ref Entity other){
		base.hit (ref other);
	}

	public override void die(){

	}
}
