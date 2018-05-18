using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Minion : Card {
	public int health, attack, maxHealth, manaCost;
	public string cardName, cardSet, tribe, rarity, classCard;
	public Ability ability;
}
