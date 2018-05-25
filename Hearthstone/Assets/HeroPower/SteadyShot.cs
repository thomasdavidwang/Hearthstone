﻿public class SteadyShot : HeroPower {

	public SteadyShot(Player p): base(){
		player = p;
		name = "steady shot";
	}

	public override void play(){
		player.opponent.takeDamage (2);
	}
}
