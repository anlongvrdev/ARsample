using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Control : MonoBehaviour
{
    public GameObject plane1;
    public GameObject plane2;
    public GameObject plane3;
    public GameObject gameObject;

    public void Button1()
    {
        plane1.gameObject.SetActive(true);
    }

    public void Button2()
    {
        plane2.gameObject.SetActive(true);
    }

    public void Button3()
    {
        plane3.gameObject.SetActive(true);
    }

    public void Button4()
    {
        gameObject.SetActive(true);
    }    
}