using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetPlantInfo : MonoBehaviour
{
    public GameObject plantInfoPanel;
    public GameObject plantIcon;
    public TextMeshProUGUI plantName;
    public TextMeshProUGUI threatLevel;
    public TextMeshProUGUI plantDescription;

    public void OpenPlantPanel()
    {
        plantInfoPanel.SetActive(true);
    }

    public void ClosePlantPanel()
    {
        plantInfoPanel.SetActive(false);
    }
}
