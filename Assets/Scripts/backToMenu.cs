﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToMenu : MonoBehaviour
{
    private void OnMouseUpAsButton()
    {
        SceneManager.LoadScene("sceneMain");         
    }
}
