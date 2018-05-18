using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Spell : Card {
	public int manaCost;
	public string className, cardSet, classCard, cardName;
	public Ability ability;
}
