﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScript : MonoBehaviour
{
    void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Train")
        {
            SceneManager.LoadScene("victory");
        }
    }
}
