using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BookContent : MonoBehaviour
{
    [SerializeField] private List<Page> pages;
    [SerializeField] private int activePageNumber;


    private void Start()
    {
        SyncPageList();
        OpenPage(0);
    }

    [ContextMenu("Sync Page List")]
    private void SyncPageList()
    {
        pages = GetComponentsInChildren<Page>(true).OrderBy(p => p.GetPageNumber()).ToList();
    }

    [ContextMenu("Open Page")]
    public void SyncPage()
    {
        OpenPage(activePageNumber);
    }

    private void OpenPage(int pageNumber)
    {
        if (pageNumber < 0 || pageNumber >= pages.Count)
        {
            Debug.LogError("Invalid page number");
            return;
        }

        foreach (var page in pages)
        {
            page.gameObject.SetActive(false);
        }

        pages[pageNumber].gameObject.SetActive(true);
    }

    [ContextMenu("Next Page")]

    public void OpenNextPage()
    {
        activePageNumber++;
        if (activePageNumber >= pages.Count)
        {
            activePageNumber = pages.Count - 1;
        }
        OpenPage(activePageNumber);
    }

    [ContextMenu("Previous Page")]
    public void OpenPreviousPage()
    {
        activePageNumber--;
        if (activePageNumber < 0)
        {
            activePageNumber = 0;
        }
        OpenPage(activePageNumber);
    }
}
