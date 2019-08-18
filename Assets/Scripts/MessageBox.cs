using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MessageBox : MonoBehaviour
{
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void showMessage(string message)
    {
        gameObject.SetActive(true);
        text.SetText(message);
    }
}
