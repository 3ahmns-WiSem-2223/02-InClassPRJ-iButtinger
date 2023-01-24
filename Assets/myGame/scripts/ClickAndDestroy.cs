using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDestroy : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
