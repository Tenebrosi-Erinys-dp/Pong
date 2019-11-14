using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    public static List<Lamp> lampList = new List<Lamp>();
    float timer = 0;
    //Time it takes to toggle lamps
    public float swapTime = 1;
    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= swapTime)
        {
            timer = 0;
            foreach(Lamp lamp in lampList)
            {
                lamp.Toggle();
                print("lamp toggled");
            }
        }
    }
}
