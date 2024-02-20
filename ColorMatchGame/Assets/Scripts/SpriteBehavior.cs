using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]

public class SpriteBehavior : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void ChangeSprite (ColorID obj)
    {
        spriteRenderer.color = obj.value;
    }

    public void ChangeRendererColor(ColorIDDataList obj)
    {
        spriteRenderer.color = obj.currentColor.value;
    }
}

