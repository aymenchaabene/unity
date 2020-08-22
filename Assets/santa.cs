using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class santa : MonoBehaviour
{
    public string MapAChanger;
    public void goSanta()
    {
        SceneManager.LoadScene(MapAChanger);
    }
}
