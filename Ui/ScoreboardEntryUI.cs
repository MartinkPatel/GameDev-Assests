using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
namespace martin.Scoreboards{
[Serializable]
public class ScoreboardEntryUI : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI entryNameText=null;
      [SerializeField] private TextMeshProUGUI entryTimeText=null;

    public void Initialise(ScoreboardEntryData scoreboardEntryData){
        entryNameText.text=scoreboardEntryData.entryName;
        entryTimeText.text=scoreboardEntryData.entryTime.ToString();
        
    }




}
}