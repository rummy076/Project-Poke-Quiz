using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEditor.Animations;

public class Action : MonoBehaviour
{
    public Questions questions;

    public healthManager health;

    public GameObject check;
    public GameObject minus;
    public Button trueButton;
    public Button falseButton;

    public UnityEvent onNextQuestion;
    void Start()
    {
        check.SetActive(false);
        minus.SetActive(false);
    }

    public void showRes(bool answer)
    {
        if (questions.qList[questions.currentQuestion].isCorrect == answer)
        {
            check.SetActive(true);
            health.Correct_Attack();
            Debug.Log("correct");
        } else
        {
            minus.SetActive(true);
            health.Incorrect_LossHP();
            Debug.Log("Incorrect");
        }


        trueButton.interactable = false;
        falseButton.interactable = false;

        StartCoroutine(showResult());
    }

    private IEnumerator showResult()
    {
        yield return new WaitForSeconds(1.0f);

        check.SetActive(false);
        minus.SetActive(false);

        trueButton.interactable = true;
        falseButton.interactable = true;

        onNextQuestion.Invoke();
    }
}
