﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Back : MonoBehaviour
{
    public string MapAChanger;
    public void back()
    {
        SceneManager.LoadScene(MapAChanger);
    }
}
