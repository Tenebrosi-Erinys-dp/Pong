using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    BoxCollider2D box;
    SpriteRenderer sr;
    Color onColor;
    Color offColor;
    private void Start()
    {
        box = GetComponent<BoxCollider2D>();
        LampController.lampList.Add(this);
        sr = GetComponent<SpriteRenderer>();
        onColor = new Color(252f / 255, 186f / 255, 0);
        offColor = new Color(36f / 255, 0, 252f / 255);
        sr.color = onColor;
    }

    public void Toggle()
    {
        box.enabled = !box.enabled;
        if (box.enabled)
        {
            sr.color = onColor;
            print("Turning on");
        }
        else
        {
            sr.color = offColor;
            print("Turning off");
        }
    }
}
