﻿/*
* Evan Meyer
* RotateWithMouse.cs
* CIS452 Assignment 3
*/

using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{
    public void Update()
    {
        var pos = Camera.main.WorldToScreenPoint(transform.position);
        var dir = Input.mousePosition - pos;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
