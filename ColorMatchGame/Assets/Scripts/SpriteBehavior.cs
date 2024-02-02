using UnityEngine;

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
}

