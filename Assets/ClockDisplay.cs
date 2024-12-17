using UnityEngine;
using UnityEngine.UI;

public class ClockDisplay : MonoBehaviour
{
    public Image clockImage;
    public Gradient fillGradient;

    private void Awake()
    {
        clockImage.type = Image.Type.Filled;
        clockImage.fillMethod = Image.FillMethod.Radial360;
        //clockImage.fillOrigin = RectTransform.FillOrigin.Center;
        clockImage.fillClockwise = true;
        //clockImage.fillGradient = fillGradient;
    }
}