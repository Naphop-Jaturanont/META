using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reactive : MonoBehaviour
{
    public static reactive instance;
    public GameObject re;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
        re.SetActive(false);
    }
    void Start()
    {
     ;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hide()
    {
        re.SetActive(false);
    }

    public void show()
    {
        re.SetActive(true);
    }
}
