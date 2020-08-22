using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    public void exit()
    {
        Debug.Log("EXIT");
        Application.Quit();
    }
}
