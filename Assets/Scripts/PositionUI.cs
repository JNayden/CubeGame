using UnityEngine.UI;
using UnityEngine;

public class PositionUI : MonoBehaviour
{
    // Update is called once per frame
    public Transform player;
    public Text text;
    void Update()
    {
        text.text = player.position.z.ToString("0");
    }
}
