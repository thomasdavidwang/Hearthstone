public class Coin : Spell {
	public Coin(){
		manaCost = -1;
		name = "coin";
		cardSet = "basic";
	}

	public override void play(ref Player p){
		base.play (ref p);
	}
}
