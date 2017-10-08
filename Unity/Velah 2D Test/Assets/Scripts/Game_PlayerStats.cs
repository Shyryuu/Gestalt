using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_PlayerStats : MonoBehaviour {

	public const int STANDARD_HEALTH = 50;
	public const int STANDARD_ARMOR = 10;

    private new string name { get; set; }
	private int strength { get; set; }
    private int finesse { get; set; }
    private int intelligence { get; set; }
    private int constitution { get; set; }
    private int wits { get; set; }
    private int memory { get; set; }
	private int maxHealth { get; set; }
	private int currentHealth { get; set; }
	private int maxArmor { get; set; }
	private int currentArmor { get; set; }


    // Use this for initialization
    void Start () {
        name = "Velah";
		strength = 0;
		finesse = 0;
		intelligence = 0;
		constitution = 0;
		wits = 0;
		memory = 0;
		maxHealth = STANDARD_HEALTH;
		currentHealth = STANDARD_HEALTH;
		maxArmor = STANDARD_ARMOR;
		currentArmor = STANDARD_ARMOR;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
