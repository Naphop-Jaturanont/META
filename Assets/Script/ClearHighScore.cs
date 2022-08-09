using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearHighScore : MonoBehaviour
{
    

    

    public void ClearScore()
    {
        PlayerPrefs.DeleteAll();
    }
}
