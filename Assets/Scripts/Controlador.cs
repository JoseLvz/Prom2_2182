using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour {

    public GameObject location;
    public GameObject Item;
    public bool Quest1,Quest2;

    int Monsters = 5;
    public bool Reached;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Quest1 == true)
        {
            Debug.Log("Quest accepted");
        }
		
	}
    void OnTriggerEnter(Collider other)
    {   
        if(other.name == "Player")
        {
            switch (Monsters)
            {
                case 1:
                    Debug.Log("4left");
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:

                    break;
                case 5:
                    Quest1 = false;
                    Debug.Log("Quest completed");
                    Quest2 = true;
                    break;
            }
        }
        
    }

}
