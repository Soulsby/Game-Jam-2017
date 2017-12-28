using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        
    }

    public void Ondeath()
    { 
        SceneManager.LoadScene("Scene1");
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
