using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableObject : MonoBehaviour
{
    public GameObject gameObject;
    public void OnDisable()
    {
        gameObject.SetActive(false);
    }
}
