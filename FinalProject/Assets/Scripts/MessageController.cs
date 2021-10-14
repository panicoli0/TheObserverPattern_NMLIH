using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MessageController : MonoBehaviour
{
    private TextMeshProUGUI message;

    // Start is called before the first frame update
    void Start()
    {
        message = GetComponent<TextMeshProUGUI>();
        message.enabled = false;
    }

    public void SetMessage(GameObject go)
    {
        message.text = "You picked up an item!!";
        message.enabled = true;
        Invoke(nameof(TurnOff), 2);
    }

    void TurnOff()
    {
        message.enabled = false;
    }
}
