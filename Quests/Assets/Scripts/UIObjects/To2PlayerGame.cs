﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class twoPlayerButtonSCript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnClick()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("2pGame");
    }
}
