using UnityEngine;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
// needs fixing
public class AxisExample : MonoBehaviour
{
    public float range;
    


    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, 0);
        Debug.Log ( "Value Returned: " + h.ToString("F2"));
    }
}