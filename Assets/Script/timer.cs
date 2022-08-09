using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public static timer instance;
    public float timeStart;
    public Text textBox;
   // public Text startBtnText;

    bool timerActive = true;

    // Use this for initialization

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        textBox.text = timeStart.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            timeStart += Time.deltaTime;
            textBox.text = timeStart.ToString("F2");
        }
    }
    public void timerButton()
    {
        timerActive = !timerActive;
        //startBtnText.text = timerActive ? "Pause" : "Start";
    }

    public void timerfalse()
    {
        timerActive = false;
    }

}
