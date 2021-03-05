using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mulclose : MonoBehaviour
{

    public GameObject complete;

    public void Clicked()
    {
        Destroy(complete);
        FindObjectOfType<MenuBarouch.MenuManager>().completetoMullevel();
    }
}
