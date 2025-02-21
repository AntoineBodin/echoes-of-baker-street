using System;
using UnityEngine;

public class OpenBookScript : MonoBehaviour
{
    [SerializeField] private GameObject book;

    private bool isOpen => book.activeSelf;

    public void OnClick()
    {
        Debug.Log("clicked");
        if (isOpen)
        {
            CloseBook();
        }
        else
        {
            OpenBook();
        }
    }

    private void OpenBook()
    {
        book.SetActive(true);
    }

    private void CloseBook()
    {
        book.SetActive(false);
    }
}
