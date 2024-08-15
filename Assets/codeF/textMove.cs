using UnityEngine;

public class textMove : MonoBehaviour
{
    // Start is called before the first frame update

    float OriginalX, OriginalY;
    private void Start()
    {
        OriginalX = 0;
        OriginalY = 0;
    }
    public void TextMove(float x, float y)
    {
        
        transform.Translate(x - OriginalX, y - OriginalY, 0);
        OriginalX = x;
        OriginalY = y;
    }
}
