public class SenjinShieldmasta : Minion {
	public SenjinShieldmasta(){
		maxHealth = 5;
		health = 5;
		attack = 3;
		manaCost = 4;
		name = "sen'jin shieldmasta";
	}

	public override void play(ref Player p){
		base.play (ref p);
		abilityList.Add ("taunt");
	}

	public override void hit(ref Entity other){
		base.hit (ref other);
	}

	public override void die(){

	}
}
