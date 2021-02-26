using System.Collections;
using UnityEngine;

public class ChangeScene : MonoBehaviour
{
    public GameObject guiObject;
    public int level;

    void Start()
    {
        guiObject.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            guiObject.SetActive(true);
            if(guiObject.activeInHierarchy)
            {
                Application.LoadLevel(level); 
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        guiObject.SetActive(false);
    }
}
