using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolsButtons : MonoBehaviour {

    [Header("Sprites")]
    public Sprite Open;
    public Sprite Close;

    [Header("Panels")]
    public GameObject InfoPanel;
    public GameObject RoomsPanel;
    public GameObject SpellsPanel;
    public GameObject TrapsPanel;
    public GameObject CreaturePanel;
    public GameObject parent;

    [Header("Sound")]
    public AudioSource TabClick;

    private GameObject Info;
    private GameObject Rooms;
    private GameObject Spells;
    private GameObject Traps;
    private GameObject Creature;

    // Use this for initialization
    void Start () {
        InfoPanel.SetActive(true);
        RoomsPanel.SetActive(false);
        SpellsPanel.SetActive(false);
        TrapsPanel.SetActive(false);
        CreaturePanel.SetActive(false);
        Info = GameObject.Find("InfoButton");
        Rooms = GameObject.Find("RoomsButton");
        Spells = GameObject.Find("SpellsButton");
        Traps = GameObject.Find("TrapsButton");
        Creature = GameObject.Find("CreatureButton");
    }
	
	// Update is called once per frame
	public void OnClick () {
		if (gameObject.name == "Info")
        {
            TabClick.Play();
            InfoPanel.SetActive(true);
            RoomsPanel.SetActive(false);
            SpellsPanel.SetActive(false);
            TrapsPanel.SetActive(false);
            CreaturePanel.SetActive(false);
        }
        if (gameObject.name == "Rooms")
        {
            TabClick.Play();
            InfoPanel.SetActive(false);
            RoomsPanel.SetActive(true);
            SpellsPanel.SetActive(false);
            TrapsPanel.SetActive(false);
            CreaturePanel.SetActive(false);
        }
        if (gameObject.name == "Spells")
        {
            TabClick.Play();
            InfoPanel.SetActive(false);
            RoomsPanel.SetActive(false);
            SpellsPanel.SetActive(true);
            TrapsPanel.SetActive(false);
            CreaturePanel.SetActive(false);
        }
        if (gameObject.name == "Traps")
        {
            TabClick.Play();
            InfoPanel.SetActive(false);
            RoomsPanel.SetActive(false);
            SpellsPanel.SetActive(false);
            TrapsPanel.SetActive(true);
            CreaturePanel.SetActive(false);
        }
        if (gameObject.name == "Creature")
        {
            TabClick.Play();
            InfoPanel.SetActive(false);
            RoomsPanel.SetActive(false);
            SpellsPanel.SetActive(false);
            TrapsPanel.SetActive(false);
            CreaturePanel.SetActive(true);
        }
    }
}
