using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class UIManager : MonoBehaviour
{
    public RectTransform add,sub, mul, div;
    public RectTransform addlevel, sublevel, mullevel, divlevel;

    public void Start()
    {
        addlevel.DOScale(0, 0);
        sublevel.DOScale(0, 0);
        mullevel.DOScale(0, 0);
        divlevel.DOScale(0, 0);
    }
    public void addactive()
    {
        add.DOAnchorPos(new Vector2(-21, 334), 0.4f);
        sub.DOAnchorPos(new Vector2(-21, -376), 0.4f);
        mul.DOAnchorPos(new Vector2(-21, -683), 0.4f);
        div.DOAnchorPos(new Vector2(-21, -964), 0.4f);
        addlevel.DOScale(1f, 0);
        sublevel.DOScale(0, 0);
        mullevel.DOScale(0, 0);
        divlevel.DOScale(0, 0);
    }
    
    public void subactive()
    {
        add.DOAnchorPos(new Vector2(-21, 334), 0.4f);
        sub.DOAnchorPos(new Vector2(-21, 53), 0.4f);
        mul.DOAnchorPos(new Vector2(-21, -683), 0.4f);
        div.DOAnchorPos(new Vector2(-21, -964), 0.4f);
        sublevel.DOScale(1f, 0);
        addlevel.DOScale(0, 0);
        mullevel.DOScale(0, 0);
        divlevel.DOScale(0, 0);
    }

    public void mulactive()
    {
        add.DOAnchorPos(new Vector2(-21, 334), 0.4f);
        sub.DOAnchorPos(new Vector2(-21, 53), 0.4f);
        mul.DOAnchorPos(new Vector2(-21, -248), 0.4f);
        div.DOAnchorPos(new Vector2(-21, -964), 0.4f);
        sublevel.DOScale(0, 0);
        addlevel.DOScale(0, 0);
        mullevel.DOScale(1, 0);
        divlevel.DOScale(0, 0);
    }

    public void divactive()
    {
        add.DOAnchorPos(new Vector2(-21, 334), 0.4f);
        sub.DOAnchorPos(new Vector2(-21, 53), 0.4f);
        mul.DOAnchorPos(new Vector2(-21, -248), 0.4f);
        div.DOAnchorPos(new Vector2(-21, -555), 0.4f);
        sublevel.DOScale(0, 0);
        addlevel.DOScale(0, 0);
        mullevel.DOScale(0, 0);
        divlevel.DOScale(1, 0);
    }
}
