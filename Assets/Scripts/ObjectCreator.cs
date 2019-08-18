using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    public GameObject[] objGroup = new GameObject[7];
    private bool canCreate = true;
    private float createInterval = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canCreate)
        {
            canCreate = false;
            int t = Random.Range(1, 3);
            Invoke("createObj", (float)t);
        }
    }

    private void createObj()
    {
        int objIndex = Random.Range(0, 7);
        int objOrder = Random.Range(1, 5);
        int objPos = Random.Range(-3, 1);
        GameObject obj = Instantiate(objGroup[objIndex], new Vector2(10, objPos), Quaternion.identity);
        obj.GetComponent<Renderer>().sortingOrder = objOrder;
        canCreate = true;
        Destroy(obj, 5f);
    }
}
