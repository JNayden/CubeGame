using UnityEngine;
using UnityEngine.UI;

public class UIPositionScript1 : MonoBehaviour
{
    // Update is called once per frame
    public Transform player;
    public Text text;
    void Update()
    {
        text.text = player.position.z.ToString();
    }
}
