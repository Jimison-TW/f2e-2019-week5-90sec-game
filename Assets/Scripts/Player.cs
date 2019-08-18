using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public Transform player;
    private bool canMove = true;
    private int currentOrder = 2;
    private Renderer myRenderer;
    private UnityAction bumpBlock;
    private UnityAction bumpWeapon;

    // Start is called before the first frame update
    void Start()
    {
        myRenderer = this.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!canMove) return;
        if (player.position.y < 1 && Input.GetKeyDown(KeyCode.UpArrow))
        {
            player.Translate(new Vector2(0, 1));
            myRenderer.sortingOrder -= 1;
        }
        else if (player.position.y > -2 && Input.GetKeyDown(KeyCode.DownArrow))
        {
            player.Translate(new Vector2(0, -1));
            myRenderer.sortingOrder += 1;
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Block")
        {
            Debug.Log("Block");
            bumpBlock.Invoke();
        }
        else if (other.gameObject.tag == "Weapon")
        {
            Debug.Log("Weapon");
            bumpWeapon.Invoke();
        }
    }

    public void setAction(UnityAction bumpWeapon, UnityAction bumpBlock)
    {
        this.bumpBlock = bumpBlock;
        this.bumpWeapon = bumpWeapon;
    }
}
