using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp : MonoBehaviour
{
    PolygonCollider2D box;
    SpriteRenderer sr;
    public Sprite onSprite;
    public Sprite offSprite;
    Color onColor;
    Color offColor;
    private void Start()
    {
        box = GetComponent<PolygonCollider2D>();
        LampController.lampList.Add(this);
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = offSprite;
        onColor = sr.color;
        offColor = onColor;
        offColor.a /= 2;
        sr.color = offColor;
    }

    public void Toggle()
    {
        box.enabled = !box.enabled;
        if (box.enabled)
        {
            sr.sprite = onSprite;
            sr.color = onColor;
        }
        else
        {
            sr.sprite = offSprite;
            sr.color = offColor;
        }
    }

    public bool IsOn()
    {
        return box.enabled;
    }

    public void TurnOn()
    {
        if (!box.enabled)
        {
            Toggle();
        }
    }

    public void TurnOff()
    {
        if (box.enabled)
        {
            Toggle();
        }
    }
}
