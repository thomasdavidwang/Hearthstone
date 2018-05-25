public class Hunter : Hero {
	public Hunter(Player p) : base(){
		health = 30;
		maxHealth = 30;
		attack = 0;
		className = "hunter";
		heroPower = new SteadyShot (p);
		weapon = null;
		armor = 0;
		player = p;
	}
}
