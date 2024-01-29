using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // Add this line to use TMP component

[RequireComponent(typeof(Text))]
[RequireComponent(typeof(TMPro.TextMeshProUGUI))] // Add this line to require TMP component

public class TextLabelBehavior : MonoBehaviour
{
    public Text label;
    public TMPro.TextMeshProUGUI tmpLabel; // Add TMP label reference
    public FloatData dataObj;
    public BoolData boolData;
    public IntData intData;  

    private void Start()
    {
        label = GetComponent<Text>();
        tmpLabel = GetComponent<TMPro.TextMeshProUGUI>(); // Assign TMP label component
        UpdateLabel();
    }
   
    public void UpdateLabel()
    {
        if (label != null)
        {
            label.text = dataObj.value.ToString();
        }
        else if (tmpLabel != null)
        {
            tmpLabel.text = dataObj.value.ToString();
        }
    }
}

