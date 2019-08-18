using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGController : MonoBehaviour
{
    public float scrollSpeed = 0.8f;
    public Renderer[] bgItems;

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2(x, 0);
        foreach (Renderer obj in bgItems)
        {
            obj.sharedMaterial.SetTextureOffset("_MainTex", offset);
        }
    }

    public void completeGame()
    {
        stopScroll();
    }

    public void stopScroll()
    {
        scrollSpeed = 0;
    }
}
