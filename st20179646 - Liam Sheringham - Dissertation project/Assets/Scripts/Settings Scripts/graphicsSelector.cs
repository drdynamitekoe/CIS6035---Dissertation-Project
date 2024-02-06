using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class graphicsSelector : MonoBehaviour
{ 
    public TMP_Dropdown graphicsDropdown; //The dropdown list

    public void setQuality(int qualityIndex) //The game quality
    {
        QualitySettings.SetQualityLevel(qualityIndex); //The game quality is set
    }
}
