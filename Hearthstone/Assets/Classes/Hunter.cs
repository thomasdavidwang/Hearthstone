public class Hunter : Hero {
	public Hunter(Board b) : base(){
		health = 30;
		maxHealth = 30;
		attack = 0;
		className = "hunter";
		heroPower = new SteadyShot (b, b.player1.opponent);
		weapon = null;
		armor = 0;
		board = b;
	}
}
