using Shapes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("Shapes Collider")]
public class ShapesColliderGenerator : MonoBehaviour
{
    private void OnValidate()
    {
        Differentiate();
    }

    private void Reset()
    {
        Differentiate();
    }

    private void Differentiate()
    {
        var shapeRenderer = GetComponent<ShapeRenderer>();
        if (shapeRenderer != null)
        {
            if (shapeRenderer is Line)
            {
                gameObject.AddComponent<ShapesLineCollider>();
                RemoveThis();
            }
            else if (shapeRenderer is Disc)
            {
                gameObject.AddComponent<ShapesDiscCollider>();
                RemoveThis();
            }
            else if (shapeRenderer is Polygon)
            {
                gameObject.AddComponent<ShapesPolygonCollider>();
                RemoveThis();
            }
            else if (shapeRenderer is Polyline)
            {
                gameObject.AddComponent<ShapesPolylineCollider>();
                RemoveThis();
            }
            else if (shapeRenderer is Triangle)
            {
                gameObject.AddComponent<ShapesTriangleCollider>();
                RemoveThis();
            }
            else
            {
                Debug.LogError("Unsupported shape.  Check for updates to the Shapes Colliders package!");
                RemoveThis();
            }
        }
    }

    private void RemoveThis()
    {
        DestroyImmediate(this);
    }
}
