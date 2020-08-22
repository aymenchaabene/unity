using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class gp : MonoBehaviour
{
    public string MapAChanger;
    public void gogp()
    {
        SceneManager.LoadScene(MapAChanger);

    }
}
