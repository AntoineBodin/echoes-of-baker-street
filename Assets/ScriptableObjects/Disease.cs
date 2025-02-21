using UnityEngine;

[CreateAssetMenu(fileName = "Disease", menuName = "Scriptable Objects/Disease")]
public class Disease : ScriptableObject
{
    public string DiseaseName;
    public string[] Symptoms;
    public string[] Remedies;
}
