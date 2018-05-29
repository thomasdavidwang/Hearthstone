public class FrostwolfWarlord : Minion {
	public FrostwolfWarlord(){
		maxHealth = 4;
		health = 4;
		attack = 4;
		manaCost = 5;
		name = "frostwolf warlord";
	}

	public override void play(ref Player p){
		for (int i = 0; i < p.board.Count - 1; i++) {
			maxHealth++;
			health++;
			attack++;
		}
		base.play (ref p);
	}

	public override void hit(ref Entity other){
		base.hit (ref other);
	}

	public override void die(){

	}
}
