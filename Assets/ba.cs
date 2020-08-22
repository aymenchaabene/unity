using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ba : MonoBehaviour
{
    public string MapAChanger;
    public void goba()
    {
        SceneManager.LoadScene(MapAChanger);
    }
}
