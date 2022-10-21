using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaveScoreLibrary : MonoBehaviour
{
    DLLStuff keycard;

    public TMP_Text WaveText;

    // Update is called once per frame
    void Update()
    {
        WaveText.text = DLLStuff.GetWaveCount("WaveScore.txt").ToString();
    }
}
