using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolsButtons : MonoBehaviour {

    [Header("Sprites")]
    public Sprite Open;
    public Sprite Close;

    [Header("Buttons")]
    public GameObject Info;
    public GameObject Rooms;
    public GameObject Spells;
    public GameObject MB;
    public GameObject Traps;
    public GameObject Creature;

    [Header("Panels")]
    public GameObject InfoPanel;
    public GameObject RoomsPanel;
    public GameObject SpellsPanel;
    public GameObject MBPanel;
    public GameObject TrapsPanel;
    public GameObject CreaturePanel;

    [Header("Sound")]
    public AudioSource TabClick;

    // Use this for initialization
    void Start () {
        InfoPanel.SetActive(true);
        RoomsPanel.SetActive(false);
        SpellsPanel.SetActive(false);
        MBPanel.SetActive(false);
        TrapsPanel.SetActive(false);
        CreaturePanel.SetActive(false);
        Info.GetComponent<Image>().sprite = Open;
        Rooms.GetComponent<Image>().sprite = Close;
        Spells.GetComponent<Image>().sprite = Close;
        MB.GetComponent<Image>().sprite = Close;
        Traps.GetComponent<Image>().sprite = Close;
        Creature.GetComponent<Image>().sprite = Close;
    }
	
	// Update is called once per frame
	public void OnClick () {
		if (gameObject == Info)
        {
            TabClick.Play();
            InfoPanel.SetActive(true);
            RoomsPanel.SetActive(false);
            SpellsPanel.SetActive(false);
            MBPanel.SetActive(false);
            TrapsPanel.SetActive(false);
            CreaturePanel.SetActive(false);
            Info.GetComponent<Image>().sprite = Open;
            Rooms.GetComponent<Image>().sprite = Close;
            Spells.GetComponent<Image>().sprite = Close;
            MB.GetComponent<Image>().sprite = Close;
            Traps.GetComponent<Image>().sprite = Close;
            Creature.GetComponent<Image>().sprite = Close;
        }
        if (gameObject == Rooms)
        {
            TabClick.Play();
            InfoPanel.SetActive(false);
            RoomsPanel.SetActive(true);
            SpellsPanel.SetActive(false);
            MBPanel.SetActive(false);
            TrapsPanel.SetActive(false);
            CreaturePanel.SetActive(false);
            Info.GetComponent<Image>().sprite = Close;
            Rooms.GetComponent<Image>().sprite = Open;
            Spells.GetComponent<Image>().sprite = Close;
            MB.GetComponent<Image>().sprite = Close;
            Traps.GetComponent<Image>().sprite = Close;
            Creature.GetComponent<Image>().sprite = Close;
        }
        if (gameObject == Spells)
        {
            TabClick.Play();
            InfoPanel.SetActive(false);
            RoomsPanel.SetActive(false);
            SpellsPanel.SetActive(true);
            MBPanel.SetActive(false);
            TrapsPanel.SetActive(false);
            CreaturePanel.SetActive(false);
            Info.GetComponent<Image>().sprite = Close;
            Rooms.GetComponent<Image>().sprite = Close;
            Spells.GetComponent<Image>().sprite = Open;
            MB.GetComponent<Image>().sprite = Close;
            Traps.GetComponent<Image>().sprite = Close;
            Creature.GetComponent<Image>().sprite = Close;
        }
        if (gameObject == MB)
        {
            TabClick.Play();
            InfoPanel.SetActive(false);
            RoomsPanel.SetActive(false);
            SpellsPanel.SetActive(false);
            MBPanel.SetActive(true);
            TrapsPanel.SetActive(false);
            CreaturePanel.SetActive(false);
            Info.GetComponent<Image>().sprite = Close;
            Rooms.GetComponent<Image>().sprite = Close;
            Spells.GetComponent<Image>().sprite = Close;
            MB.GetComponent<Image>().sprite = Open;
            Traps.GetComponent<Image>().sprite = Close;
            Creature.GetComponent<Image>().sprite = Close;
        }
        if (gameObject == Traps)
        {
            TabClick.Play();
            InfoPanel.SetActive(false);
            RoomsPanel.SetActive(false);
            SpellsPanel.SetActive(false);
            MBPanel.SetActive(false);
            TrapsPanel.SetActive(true);
            CreaturePanel.SetActive(false);
            Info.GetComponent<Image>().sprite = Close;
            Rooms.GetComponent<Image>().sprite = Close;
            Spells.GetComponent<Image>().sprite = Close;
            MB.GetComponent<Image>().sprite = Close;
            Traps.GetComponent<Image>().sprite = Open;
            Creature.GetComponent<Image>().sprite = Close;
        }
        if (gameObject == Creature)
        {
            TabClick.Play();
            InfoPanel.SetActive(false);
            RoomsPanel.SetActive(false);
            SpellsPanel.SetActive(false);
            MBPanel.SetActive(false);
            TrapsPanel.SetActive(false);
            CreaturePanel.SetActive(true);
            Info.GetComponent<Image>().sprite = Close;
            Rooms.GetComponent<Image>().sprite = Close;
            Spells.GetComponent<Image>().sprite = Close;
            MB.GetComponent<Image>().sprite = Close;
            Traps.GetComponent<Image>().sprite = Close;
            Creature.GetComponent<Image>().sprite = Open;
        }
    }
}
