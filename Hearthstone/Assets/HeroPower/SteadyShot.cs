public class SteadyShot : HeroPower {

	public SteadyShot(Player p): base(){
		player = p;
		name = "steady shot";
	}

	public override void play(ref Player p){
		player.opponent.takeDamage (2);
		base.play (ref p);
	}
}
