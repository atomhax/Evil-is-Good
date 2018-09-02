using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterScript : MonoBehaviour {

	public bool inGame;
	public int goldTotal = 2048;
	public List<GameObject> inHand;

	[Header("Rooms Unlocked")]
	public bool isGold = true;
	public bool isLair;
	public bool isHatchery;
	public bool isTraining;
	public bool isLibrary;
	public bool isBridge;
	public bool isPost;
	public bool isWorkshop;
	public bool isJail;
	public bool isTorture;
	public bool isGuard;
	public bool isWorship;
	public bool isGraveyard;
	public bool isScavenger;

	[Header("Spells Unlocked")]
	public bool isPossess = true;
	public bool isImp = true;
	public bool isThunder;
	public bool isHeal;
	public bool isSight;
	public bool isCall;
	public bool isTremor;
	public bool isTurncoat;
	public bool isChicken;

	[Header("Rooms Gold Amount")]
	public int goldAmount = 50;
	public int lairAmount = 100;
	public int hatcheryAmount = 150;
	public int trainingAmount = 175;
	public int libraryAmount = 200;
	public int bridgeAmount = 30;
	public int postAmount = 50;
	public int workshopAmount = 175;
	public int jailAmount = 255;
	public int tortureAmount = 275;
	public int gaurdAmount = 225;
	public int worshipAmount = 300;
	public int graveyardAmount = 350;
	public int scavengerAmount = 750;

	[Header("Spells Gold Amount")]
	public int possessAmount = 0;
	public int impAmount = 50;
	public int thunderAmount = 700;
	public int healAmount = 500;
	public int sightAmount = 300;
	public int callAmount = 1;
	public int tremorAmount = 750;
	public int turncoatAmount = 1000;
	public int chickenAmount = 1250;

	[Header("Using Things")]
	public bool usingGold;
	public bool usingLair;
	public bool usingHatchery;
	public bool usingTraining;
	public bool usingLibrary;
	public bool usingBridge;
	public bool usingPost;
	public bool usingWorkshop;
	public bool usingJail;
	public bool usingTorture;
	public bool usingGuard;
	public bool usingWorship;
	public bool usingGraveyard;
	public bool usingScavenger;
	public bool usingPossess;
	public bool usingImp;
	public bool usingThunder;
	public bool usingHeal;
	public bool usingSight;
	public bool usingCall;
	public bool usingTremor;
	public bool usingTurncoat;
	public bool usingChicken;

	[Header("Traps & Doors Unlocked")]
	public bool isGas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
