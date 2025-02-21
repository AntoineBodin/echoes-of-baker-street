using Assets._Scripts.Extensions;
using System;
using UnityEngine;

public class OpenBookScript : MonoBehaviour
{
    [SerializeField] private GameObject book;

    public void OnClick()
    {
        Debug.Log("clicked");
        book.SwitchOnOff();
    }
}
