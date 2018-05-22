abstract public class Entity : Card {
	public int health, attack, maxHealth;
	public string name;
	public bool alive;

	public Entity(){

	}

	abstract public void takeDamage (int damage);
	abstract public void hit (Entity other);
}
