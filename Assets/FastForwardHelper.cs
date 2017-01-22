using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastForwardHelper : MonoBehaviour
{
    
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKey(KeyCode.F5) && Input.GetKey(KeyCode.F1))
        {
            Time.timeScale = 10;
        }
        else
        {
            Time.timeScale = 1;
        }
	}
}
