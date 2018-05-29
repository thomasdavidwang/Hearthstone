public class GnomishInventor : Minion {
	public GnomishInventor(){
		maxHealth = 4;
		health = 4;
		attack = 2;
		manaCost = 4;
		name = "gnomish inventor";
	}

	public override void play(ref Player p){
		p.drawCard ();
		base.play (ref p);
	}

	public override void hit(ref Entity other){
		base.hit (ref other);
	}

	public override void die(){

	}
}
