using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
    public bool IsCorrect = false;
    public QuizManager QuizMan;
   public void Answer()
   {
    if(IsCorrect)
    {
        Debug.Log("Correct answer");
        QuizMan.correct();
    }
    else{
        Debug.Log("wrong answer");
         QuizMan.wrong();

    }


   }
}
