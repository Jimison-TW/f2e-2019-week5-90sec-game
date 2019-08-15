using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.y < 1 && Input.GetKeyDown(KeyCode.UpArrow))
        {
            player.Translate(new Vector2(0, 1));
        }
        else if (player.position.y > -2 && Input.GetKeyDown(KeyCode.DownArrow))
        {
            player.Translate(new Vector2(0, -1));
        }

        if (player.position.x < 8 && Input.GetKey(KeyCode.RightArrow))
        {
            player.Translate(Vector3.right * Time.deltaTime * 5);
        }
        else if (player.position.x > -8 && Input.GetKey(KeyCode.LeftArrow))
        {
            player.Translate(Vector3.left * Time.deltaTime * 5);
        }
    }
}
