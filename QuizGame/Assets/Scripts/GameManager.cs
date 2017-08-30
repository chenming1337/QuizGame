using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public static bool answeredRight = false;
    public static bool startQuiz = false;
    public GameObject quizWindow;
    public GameObject feedbackWindow;
    public GameObject toggle1, toggle2, toggle3, toggle4;
    // Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(startQuiz);
        if (!startQuiz)
        {
            quizWindow.SetActive(false);
            feedbackWindow.SetActive(false);
        }
        else if (startQuiz)
        {
            quizWindow.SetActive(true);
        }
	}

    public void SubmitButtonPressed() {
        feedbackWindow.SetActive(true);
        if (QuizTextControl.questionNum == 1 && toggle1.GetComponent<Toggle>().isOn) {
            answeredRight = true;
        }
        if (QuizTextControl.questionNum == 2 && toggle3.GetComponent<Toggle>().isOn)
        {
            answeredRight = true;
        }
        if (QuizTextControl.questionNum == 3 && toggle3.GetComponent<Toggle>().isOn)
        {
            answeredRight = true;
        }
    }

    public void FeedbackButtonPressed() {
        toggle1.GetComponent<Toggle>().isOn = false;
        toggle2.GetComponent<Toggle>().isOn = false;
        toggle3.GetComponent<Toggle>().isOn = false;
        toggle4.GetComponent<Toggle>().isOn = false;
        if (answeredRight)
        {
            startQuiz = false;
        }
        else
        {
            feedbackWindow.SetActive(false);
        }
    }
}
