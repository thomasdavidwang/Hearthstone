abstract public class Spell : Card {
	public string cardSet, classCard;

	public override void play(ref Player p){
		p.useMana (manaCost);
	}
}
