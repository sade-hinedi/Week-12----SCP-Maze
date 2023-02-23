using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckUnlock5 : MonoBehaviour
{
    public GameObject door = null;

    // Start is called before the first frame update
    void Start()
    {
        door.SetActive(true);
    }

    private void OnTriggerEnter(Collider key)
    {
        if (key.gameObject.CompareTag("Key5"))
        {
            door.SetActive(false);
        }
    }
}
