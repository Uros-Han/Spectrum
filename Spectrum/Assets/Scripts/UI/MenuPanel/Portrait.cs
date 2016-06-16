using UnityEngine;
using System.Collections;

public class Portrait : MonoBehaviour
{
    void Start()
    {
    }

    void OnClick()
    {
        transform.parent.BroadcastMessage("DisableThisPortrait");
        GetComponent<UIButtonColor>().defaultColor = GetComponent<UIButtonColor>().hover;
    }

    void DisableThisPortrait()
    {
        GetComponent<UIButtonColor>().defaultColor = new Color(199/255f, 199/255f, 199 / 255f);
    }
}
