using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    public static List<Lamp> lampList = new List<Lamp>();
    float timer = 0;
    int lampCount = 0;
    //Time it takes to toggle lamps
    public float swapTime = 1;
    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= swapTime)
        {
            timer = 0;
            for(int i = 0; i < lampList.Count; i++)
            {
                if(i == lampCount)
                {
                    lampList[i].TurnOn();
                }
                else
                {
                    lampList[i].TurnOff();
                }
            }
            lampCount++;
            if(lampCount >= lampList.Count)
            {
                lampCount = 0;
            }
        }
    }
}
