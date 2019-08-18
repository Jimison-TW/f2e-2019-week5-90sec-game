using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    private Transform myObj;
    private bool canMove = true;
    private Renderer myRenderer;

    // Start is called before the first frame update
    void Start()
    {
        myObj = GetComponent<Transform>();
        myRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            Vector2 offset = new Vector2(-0.08f, 0);
            myObj.Translate(offset);
        }
    }

    public void setOrder(int i)
    {
        myRenderer.sortingOrder = i;
    }
}
