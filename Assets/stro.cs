using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class stro : MonoBehaviour
{
    public string MapAChanger;
    public void gostro()
    {
        SceneManager.LoadScene(MapAChanger);

    }
}
