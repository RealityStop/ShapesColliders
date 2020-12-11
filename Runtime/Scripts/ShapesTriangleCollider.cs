﻿using Shapes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("")]
[ExecuteInEditMode]
[RequireComponent(typeof(PolygonCollider2D))]
[RequireComponent(typeof(Triangle))]
public class ShapesTriangleCollider : ShapesCollider
{
    Triangle triangle;
    Vector3 A;
    Vector3 B;
    Vector3 C;

    private void Start()
    {
        triangle = GetComponent<Triangle>();
    }

    public void Update()
    {
        if (A != triangle.A || B != triangle.B || C != triangle.C)
            UpdateData();
    }

    public override void UpdateData()
    {
        if (poly == null) { return; }

        A = new Vector2(triangle.A.x, triangle.A.y);
        B = new Vector2(triangle.B.x, triangle.B.y);
        C = new Vector2(triangle.C.x, triangle.C.y);
        Refresh();
    }

    protected override void Refresh()
    {
        List<Vector2> points = new List<Vector2>
        {
            A,B,C
        };
        poly.points = points.ToArray();
    }
}
