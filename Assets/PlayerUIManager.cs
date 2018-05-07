using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUIManager : MonoBehaviour {

    public TextMeshProUGUI health;


    void Start ()
    {
        health = GameObject.Find("Health").GetComponent<TextMeshProUGUI>();
	}
	
	void Update ()
    {
        UpdateHealth();
	}

    void UpdateHealth()
    {
        var temp = GameObject.Find("Maya").GetComponent<PlayerController>().playerHealth;
        health.text = temp.ToString();
    }
}
