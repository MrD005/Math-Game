using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Divclose : MonoBehaviour
{
    public GameObject complete;
    public GameObject Level;

    public void Clicked()
    {
        Destroy(complete);
        Destroy(Level);
        FindObjectOfType<MenuBarouch.MenuManager>().completetoDivlevel();
    }
    
}
