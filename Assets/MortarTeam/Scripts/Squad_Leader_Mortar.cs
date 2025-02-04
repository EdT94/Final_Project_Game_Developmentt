﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Squad_Leader_Mortar : MonoBehaviour {

    public MortarCrewLoader[] myCrew;
    private Animator myAnim;

    // Use this for initialization
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "DefendScene")
            FireMortar();
    }

    public void FireMortar()
    {
        foreach (MortarCrewLoader crew in myCrew)
        {
            crew.EnableFireMortar();
        }
        myAnim.SetTrigger("fire");
    }
}
