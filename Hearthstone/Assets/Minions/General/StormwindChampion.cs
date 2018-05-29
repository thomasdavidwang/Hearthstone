public class StormwindChampion : Minion {
	//Modified as a one-time boost
	public StormwindChampion(){
		maxHealth = 6;
		health = 6;
		attack = 6;
		manaCost = 7;
		name = "stormwind champion";
	}

	public override void play(ref Player p){
		foreach(Minion m in p.board){
			m.attack++;
			m.health++;
			m.maxHealth++;
		}
		base.play (ref p);
	}

	public override void hit(ref Entity other){
		base.hit (ref other);
	}

	public override void die(){

	}
}
