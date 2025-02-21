using TMPro;
using UnityEngine;

public class Page : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] private TMP_Text pageNumberText;

    [Header("Values")]
    [SerializeField] private int pageNumber;

    private void Start()
    {
        UpdateUI();
    }

    [ContextMenu("UpdateUI")]
    public virtual void UpdateUI()
    {
        if (pageNumber == 0)
        {
            pageNumberText.text = "";
        }
        else
        {
            pageNumberText.text = pageNumber.ToString();
        }
    }

    public int GetPageNumber()
    {
        return pageNumber;
    }
}