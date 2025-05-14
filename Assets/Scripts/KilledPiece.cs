using UnityEngine;
using UnityEngine.UI;

public class KilledPiece : MonoBehaviour
{
    public bool killed;

    RectTransform rect;
    Image img;

    public void Initialize(Sprite piece, Vector2 start)
    {
        killed = true;

        img = GetComponent<Image>();
        rect = GetComponent<RectTransform>();
        img.sprite = piece;
        rect.anchoredPosition = start;
    }

}
