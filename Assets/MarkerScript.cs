using UnityEngine;
using UnityEngine.UI;

public class MarkerScript : MonoBehaviour
{

    void Start()
    {

    }

    void OnMouseDown()
    {
        // this object was clicked - do something
       Debug.Log(this.gameObject);
    }
}