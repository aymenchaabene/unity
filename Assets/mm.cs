using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mm : MonoBehaviour
{
    public string MapAChanger;
    public void gomm()
    {
        SceneManager.LoadScene(MapAChanger);
    }
}
