using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour {
    
    public Coins coins;

	// Use this for initialization
	void OnTriggerEnter (Collider other) {
        Debug.Log("hi");
        coins = other.transform.parent.GetComponent<Coins>();
        coins.add();
        GameObject.Destroy(this.gameObject);
	}
	
}
