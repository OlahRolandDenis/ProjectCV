using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QandA> QnA;
    public GameObject[] options;
    public int currentQuestionIndex;
    public TMP_Text QuestionText;
    public GameObject QuizPanel;
    public GameObject FinishPanel;
    public TMP_Text ScoreText;
     public int TotalScore;
     public int Score = 0;
    public void Start()
    {
        TotalScore = QnA.Count;
        FinishPanel.SetActive(false);
        generateQuestions();

    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void GameOver()
    {
        QuizPanel.SetActive(false);
        FinishPanel.SetActive(true);
        ScoreText.text = Score + "/" + TotalScore;
       

    }
    public void correct()
    {
        Score = Score + 1;
        QnA.RemoveAt(currentQuestionIndex);
        generateQuestions();

    }
    public void wrong()
    {
       QnA.RemoveAt(currentQuestionIndex);
        generateQuestions();

    }

    public void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Answers>().IsCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TMP_Text>().text = QnA[currentQuestionIndex].Answers[i];
            if(QnA[currentQuestionIndex].CorrectAnswerIndex == i)
            {
                options[i].GetComponent<Answers>().IsCorrect = true;
            }


        }
    }

    public void generateQuestions()
    {
        if(QnA.Count>0)
        {
        currentQuestionIndex = Random.Range(0, QnA.Count);
        QuestionText.text = QnA[currentQuestionIndex].Question;
        SetAnswers();
        }
        else
        {
        Debug.Log("Ai raspuns la toate intrebarile");
        GameOver();
        }
        
    }
    

}

