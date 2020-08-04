using UnityEngine;
using UnityEngine.UI;

public class PositionController : MonoBehaviour
{
    public Transform player;
    public Text positionText;

    void Update()
    {
        positionText.text = "(" + player.position.x.ToString("0") +  ", " + player.position.z.ToString("0") + ")";
    }
}
