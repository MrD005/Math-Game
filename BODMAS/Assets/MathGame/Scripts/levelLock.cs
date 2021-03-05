using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelLock : MonoBehaviour
{
    
    public Button[] _level;
    private void Start()
    {
        _level[2].interactable = false;
    }

}
