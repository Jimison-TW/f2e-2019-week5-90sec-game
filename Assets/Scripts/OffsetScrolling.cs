using UnityEngine;

public class OffsetScrolling : MonoBehaviour
{
    public float scrollSpeed;

    private Renderer mRenderer;
    private Vector2 savedOffset;

    void Start()
    {
        mRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
        Vector2 offset = new Vector2(x, 0);
        mRenderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
