using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class subclose : MonoBehaviour
{
    public GameObject complete;

    public void Clicked()
    {
        Destroy(complete);
        FindObjectOfType<MenuBarouch.MenuManager>().completetoSUBlevel();
    }
}
