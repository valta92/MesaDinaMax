using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour {

    public List<Sprite> healthBar = new List<Sprite>();


    public Image healthBarGameobject;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


    void SetHealthBar(int value)
    {
        if (value > healthBar.Count)
            return;


        healthBarGameobject.sprite = healthBar[value];

    }
}
