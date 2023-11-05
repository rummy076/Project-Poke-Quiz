using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionData : MonoBehaviour
{
    public Questions questions;
    [SerializeField] private Text _questionText;
    void Start()
    {
        AskQuestion();
    }

    public void AskQuestion()
    {
        if(CountValidQuestions() == 0)
        {
            _questionText.text = string.Empty;
            ClearQuestions();
            SceneManager.LoadScene(0);
            return;
        }

        var randomIndex = 0;
        do
        {
            randomIndex = UnityEngine.Random.Range(0, questions.qList.Count);
        } while (questions.qList[randomIndex].questioned == true);

        questions.currentQuestion = randomIndex;
        questions.qList[questions.currentQuestion].questioned = true;
        _questionText.text = questions.qList[questions.currentQuestion].question;
    }

    public void ClearQuestions()
    {
        foreach (var q in questions.qList)
        {
            q.questioned = false;
        }
    }
    private int CountValidQuestions()
    {
        int validQuestions = 0;

        foreach (var q in questions.qList)
        {
            if(q.questioned == false)
            {
                validQuestions++;
            }
        }

        Debug.Log("Questions Left " + validQuestions);
            return validQuestions;
    }
}
