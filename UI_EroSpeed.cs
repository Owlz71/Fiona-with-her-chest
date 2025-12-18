using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class UI_EroSpeed : MonoBehaviour
{
    public Animator ani;
    [SerializeField] private float normalSpeed = 1f;
    [SerializeField] private float lowSpeed = 0.5f;
    [SerializeField] private float highSpeed = 2f;

    public void DoSex()
    {
        ani.speed = normalSpeed;
        ani.Play("root|Sex_U_1");
    }

    public void ChangeLowSpeed()
    {
        //ani.speed = lowSpeed;
        ani.Play("root|Sex_U_2");
        
    }

    public void ChangeHighSpeed()
    {
        ani.speed = highSpeed;
    }
}