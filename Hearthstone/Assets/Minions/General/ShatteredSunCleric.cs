public class ShatteredSunCleric : Minion {
	public ShatteredSunCleric(){
		maxHealth = 2;
		health = 2;
		attack = 3;
		manaCost = 3;
		name = "shattered sun cleric";
	}

	public void play(ref Minion m, ref Player p){
		m.maxHealth = m.maxHealth + 1;
		m.health = m.health + 1;
		m.attack = m.attack + 1;
		base.play (ref p);
	}

	public override void hit(ref Entity other){
		base.hit (ref other);
	}

	public override void die(){

	}
}
