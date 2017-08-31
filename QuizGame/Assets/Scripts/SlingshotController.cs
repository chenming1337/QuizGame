using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingshotController : MonoBehaviour {
    public GameObject quizWindow;

    Vector3 mousePosition;
    float resetAnim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = new Vector2(mousePosition.x, transform.position.y);
        
        if (Input.GetMouseButtonDown(0) && !quizWindow.activeSelf)
        {
            GetComponent<Animator>().SetBool("Shoot", true);
            resetAnim = 0.018f;
        }

        if (resetAnim > 0)
        {
            resetAnim -= Time.deltaTime;
        }
        if(resetAnim <= 0)
        {
            GetComponent<Animator>().SetBool("Shoot", false);
        }
    }
}
