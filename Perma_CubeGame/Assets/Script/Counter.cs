using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Counter : MonoBehaviour
{
    public int counterValue = 0;
    public static Counter Instance;
    public TMP_Text tmpText;
    void Start()
    {
        Instance = this;
    }
    public void IncreaseCounter()
    {
        counterValue++;
        tmpText.text = counterValue.ToString();
    }
}
