using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
[System.Serializable]
public class Questions : ScriptableObject
{
    [System.Serializable]

    public class QuestionData
    {
        public string question = string.Empty;
        public bool isCorrect = false;
        public bool questioned = false;
    }

    public int currentQuestion = 0;
    public List<QuestionData> qList;

    public void AddQuestion()
    {
        qList.Add(new QuestionData());
    }
}

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEditor.Animations;

public class Action : MonoBehaviour
{
    public Questions questions;
    public Animator playerAnim;
    public Animator enemyAnim;

    public GameObject check;
    public GameObject minus;
    public healthManager health;

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
        check.SetActive(questions.qList[questions.currentQuestion].isCorrect == answer);
        minus.SetActive(questions.qList[questions.currentQuestion].isCorrect != answer);

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
}*/
