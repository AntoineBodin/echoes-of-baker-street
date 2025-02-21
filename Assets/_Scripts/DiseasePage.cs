using System.Linq;
using TMPro;
using UnityEngine;

public class DiseasePage : Page
{
    [Space(10)]
    [Header("Disease UI Elements")]
    [SerializeField] private TMP_Text diseaseNameText;
    [SerializeField] private TMP_Text symptomsText;
    [SerializeField] private TMP_Text remediesText;

    [Header("Disease Values")]
    [SerializeField] private Disease disease;

    private void Start()
    {
        UpdateUI();
    }


    [ContextMenu("UpdateUI Disease")]
    public override void UpdateUI()
    {
        base.UpdateUI();
        diseaseNameText.text = disease.DiseaseName;
        symptomsText.text = string.Join('\n', disease.Symptoms);
        remediesText.text = string.Join ("\n", disease.Remedies);
    }
}
