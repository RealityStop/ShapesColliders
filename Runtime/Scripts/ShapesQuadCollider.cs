using Shapes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("")]
[ExecuteInEditMode]
[RequireComponent(typeof(PolygonCollider2D))]
[RequireComponent(typeof(Quad))]
public class ShapesQuadCollider : ShapesCollider
{
    Quad quad;
    Vector3 A;
    Vector3 B;
    Vector3 C;
    Vector3 D;

    private void Start()
    {
        quad = GetComponent<Quad>();
    }

    public void Update()
    {
        if (A != quad.A || B != quad.B || C != quad.C || D != quad.D)
            UpdateData();
    }

    public override void UpdateData()
    {
        if (poly == null || quad == null) { return; }

        A = new Vector2(quad.A.x, quad.A.y);
        B = new Vector2(quad.B.x, quad.B.y);
        C = new Vector2(quad.C.x, quad.C.y);
        D = new Vector2(quad.D.x, quad.D.y);
        Refresh();
    }

    protected override void Refresh()
    {
        List<Vector2> points = new List<Vector2>
        {
            A,B,C,D
        };
        poly.points = points.ToArray();
    }
}