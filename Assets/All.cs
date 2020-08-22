using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class All : MonoBehaviour
{
    public string MapAChanger;
    public void Games()
    {
        SceneManager.LoadScene(MapAChanger);
    }
}
