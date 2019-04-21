using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDataFetcher : MonoBehaviour
{
    public Text resultMessageText;

    // Start is called before the first frame update
    void Start()
    {
        resultMessageText.text = DataSender.resultMessage;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
