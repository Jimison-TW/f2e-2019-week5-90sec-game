using UnityEngine;

public class OffsetScrolling : MonoBehaviour
{
    public float scrollSpeed;
    private bool canScroll = true;

    private Renderer mRenderer;
    private Vector2 savedOffset;

    void Start()
    {
        mRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (canScroll)
        {
            float x = Mathf.Repeat(Time.time * scrollSpeed, 1);
            Vector2 offset = new Vector2(x, 0);
            mRenderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
        }
    }

    public void stopScroll()
    {
        this.canScroll = false;
    }
}
