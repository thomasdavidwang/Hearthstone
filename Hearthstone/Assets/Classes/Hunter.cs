public class Hunter : Hero {
	public Hunter() : base(){
		health = 30;
		maxHealth = 30;
		attack = 0;
		className = "hunter";
		weapon = null;
		armor = 0;

	}

	public override void addPlayer(ref Player p){
		player = p;
		heroPower = new SteadyShot (p);
	}
}
