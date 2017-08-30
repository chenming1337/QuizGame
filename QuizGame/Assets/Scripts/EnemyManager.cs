using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyManager : MonoBehaviour {
    public GameObject explosion;

    float speed;
	// Use this for initialization
	void Start () {
        speed = 2f;
	}
	
	// Update is called once per frame
	void Update () {
        //Get position
        Vector2 position = transform.position;
        //Compute the enemy new position
        position = new Vector2(position.x + speed*Time.deltaTime, position.y);
        //Update position   
        transform.position = position;

        if (transform.position.x > 4f)
        {
            
            transform.position = new Vector2(-4f, Random.Range(-1f, 2.4f));
        }
	}
    void OnMouseDown(){
        if (!EventSystem.current.IsPointerOverGameObject()) {
            if (gameObject.name == "Question1")
            {
                QuizTextControl.questionNum = 1;
                GameManager.startQuiz = true;
            }
            else if (gameObject.name == "Question2")
            {
                QuizTextControl.questionNum = 2;
                GameManager.startQuiz = true;
            }
            else if (gameObject.name == "Question3")
            {
                QuizTextControl.questionNum = 3;
                GameManager.startQuiz = true;
            }
            Instantiate(explosion, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
