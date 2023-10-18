using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    private Transform m_transform;

    void Start()
    {
        m_transform = this.transform;
    }

    private void LookMouse()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - m_transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; //Angle to face cursor
        Quaternion rotation = Quaternion.AngleAxis(angle - 0, Vector3.forward); //vector3 is z axis
        m_transform.rotation = rotation;
    }

    void Update()
    {
        LookMouse();
    }
}
