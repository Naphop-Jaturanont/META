using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ison1 : MonoBehaviour
{
    public bool button1 = false;
    public bool button2 = false;
    public bool button3 = false;
    public bool button4 = false;
    public Material Green;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (button1 && button2 && button3 == true)
        {
            button4 = true;
        }

        if (button4 == true) 
        {
          changegreen();
          timer.instance.timerfalse();
          reactive.instance.show();
        }
    }

    public void setbutton1()
    {
        button1 = true;
    }

    public void setbutton2()
    {
        button1 = true;
    }

    public void setbutton3()
    {
        button1 = true;
    }

    public void changegreen()
    {
        Renderer rend = GetComponent<Renderer>();
        if (rend != null)
        {
            rend.material = Green;
        }
    }

}
