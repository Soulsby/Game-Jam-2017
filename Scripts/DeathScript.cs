using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour {

    public Vector3 spawn;

    void OnTriggerEnter(Collider other)
    {
        other.transform.parent.position = spawn;  
    
    }

    public void Ondeath()
    { 
      
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
