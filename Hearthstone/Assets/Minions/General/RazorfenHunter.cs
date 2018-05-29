public class RazorfenHunter : Minion {
	public RazorfenHunter(){
		maxHealth = 3;
		health = 3;
		attack = 2;
		manaCost = 3;
		name = "razorfen hunter";
	}

	public override void play(ref Player p){
		Minion boar = new Boar ();
		p.board.Add(boar);
		boar.play (ref p);
		base.play (ref p);
	}

	public override void hit(ref Entity other){
		base.hit (ref other);
	}

	public override void die(){

	}
}
