using UnityEngine;
using UnityEngine.UI;

public class ColorLerp : MonoBehaviour
{
    public Image panel;
    // Start is called before the first frame update
    [SerializeField] [Range(0f, 1f)] float lerpTime = 0;

    [SerializeField] Color[] myColors;
    int colorIndex = 0;
    float t = 0f;
    int len;

    void Start()
    {
        panel.GetComponent<Image>();
        len = myColors.Length;
    }

    // Update is called once per frame
    void Update()
    {
        panel.material.color = Color.Lerp(panel.material.color, myColors[colorIndex], lerpTime * Time.deltaTime);

        t = Mathf.Lerp(t, 1f, lerpTime* Time.deltaTime);
        if (t > .0f)
        {
            t = 0f;
            colorIndex++;
            colorIndex = (colorIndex >= len) ? 0 : colorIndex;
        }
    }
}
