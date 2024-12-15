using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLink : MonoBehaviour
{
    public void OpenMapApp()
    {
        Application.OpenURL("https://www.google.com/maps");
    }    
}
