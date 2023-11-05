using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class healthManager : MonoBehaviour
{
    public Slider pSlide;
    public Slider eSlide;

    public Text scoreText;
    

    public void Start()
    {
        pSlide.maxValue = 100;
        pSlide.value = 100;
        eSlide.maxValue = 100;
        eSlide.value = 100;
    }

    private void Update()
    {
        if(pSlide.value <= 0 || eSlide.value <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Correct_Attack()
    {
        eSlide.value = eSlide.value > 0 ? eSlide.value - 20 : 0;
    }
    public void Incorrect_LossHP()
    {
        pSlide.value = pSlide.value > 0 ? pSlide.value - 20 : 0;
    }
}
