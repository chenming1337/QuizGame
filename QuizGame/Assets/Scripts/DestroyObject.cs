using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {
    float countDown = 0.7f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        countDown -= Time.deltaTime;
        if (countDown <= 0)
        {
            Destroy(gameObject);
        }
	}
}
