using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillStat : MonoBehaviour
{
    public Text Kill_Stat;
    public int counter = 0;

    public void StartTrack()
    {
        Kill_Stat.text = "0";
    }

    private void SetStatText()
    {
        Kill_Stat.text = counter.ToString();
        
    }

    public void AddStat()
    {
        counter++;
        SetStatText();
    }
}
