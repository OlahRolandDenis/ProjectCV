using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public List<QandA> QnA;
    public GameObject[] options;
    public int currentQuestionIndex;
    public Text QuestionText;
    public void Start()
    {
        generateQuestions();

    }
    public void generateQuestions()
    {
        currentQuestionIndex = Random.Range(0, QnA.Count);
        QuestionText.text = QnA[currentQuestionIndex].Question;
    }
    public void Answers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].transform.GetChild(0).GetComponent<Text>().text = QnA[currentQuestionIndex].Answers[i];


        }
    }

}

