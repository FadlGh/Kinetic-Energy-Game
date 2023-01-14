using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public GameObject ball;
    public Slider slider;

    public TextMeshProUGUI buttonText;
    public void Click()
    {
        ball.GetComponent<ball>().rb.mass = slider.value;
        ball.GetComponent<ball>().add = true;
        slider.GetComponent<CanvasGroup>().interactable = false;
        GetComponent<CanvasGroup>().interactable = false;
    }
}
