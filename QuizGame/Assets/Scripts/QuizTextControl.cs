using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizTextControl : MonoBehaviour {
    public static int questionNum;

    List<string> questions = new List<string>() {"1+1=?","2+2=?","3+3=?"};

    List<string> answer1 = new List<string>() { "2","10","2" };
    List<string> answer2 = new List<string>() { "4", "2", "11" };
    List<string> answer3 = new List<string>() { "6", "4", "6" };
    List<string> answer4 = new List<string>() { "8", "6", "8" };
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        if(questionNum != 0)
        {
            //set question texts and answer texts
            if (gameObject.name == "Question")
            {
                GetComponent<Text>().text = questions[questionNum - 1];
            }
            else if (gameObject.name == "Answer1")
            {
                GetComponent<Text>().text = answer1[questionNum - 1];
            }
            else if (gameObject.name == "Answer2")
            {
                GetComponent<Text>().text = answer2[questionNum - 1];
            }
            else if (gameObject.name == "Answer3")
            {
                GetComponent<Text>().text = answer3[questionNum - 1];
            }
            else if (gameObject.name == "Answer4")
            {
                GetComponent<Text>().text = answer4[questionNum - 1];
            }
            //feedback depends on if you answered the question correctly
            if (gameObject.name == "FeedbackTxt") {
                if (GameManager.answeredRight)
                {
                    GetComponent<Text>().text = "Correct!";
                }
                else {
                    GetComponent<Text>().text = "Incorrect!";
                }
            }
        }
    }
}
