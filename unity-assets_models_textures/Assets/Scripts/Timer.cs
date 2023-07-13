using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] Text TimerText;
    System.DateTime startTime;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnEnable()
    {
        startTime = System.DateTime.Now;

    }

    void OnDisable()
    {
        TimerText.color = Color.green;
        TimerText.fontSize = 60;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTimerText();
    }

    void UpdateTimerText()
    {
        if( TimerText == null)
            return;
        System.TimeSpan timeSpan = System.DateTime.Now - startTime;
        TimerText.text = timeSpan.ToString("mm':'ss'.'ff");
    }
}