public class LifeTap : HeroPower {

	public LifeTap(Player p) : base(){
		player = p;
		name = "life tap"
	}
	
	public override void play(){
		player.hero.takeDamage (2);
		player.drawCard ();
	}
}
