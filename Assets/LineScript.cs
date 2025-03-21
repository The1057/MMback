using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineScript : MaskableGraphic
{
    public Vector2 gridSize;
    public List<Vector2> points;

    float width,height;
    float cellWidth,cellHeight;

    public float lineThickness=10f;
    protected override void OnPopulateMesh(VertexHelper vh)
    {
        vh.Clear();
        width = rectTransform.rect.width;
        height = rectTransform.rect.height;

        cellHeight = height/(float)gridSize.y;
        cellWidth = width/(float)gridSize.x;
        if(points.Count < 2) return;
        for(int i = 0; i < points.Count; i++)
        {
            Vector2 point = points[i];
            drawPoint(point,vh);
        }

        for (int i = 0; i < points.Count-1; i++)
        {
            int index = i * 2;
            vh.AddTriangle(index+0,index+1,index+3);
            vh.AddTriangle(index+3,index+2,index+0);
        }
    }
    void drawPoint(Vector2 point, VertexHelper vh)
    {
        UIVertex vertex = UIVertex.simpleVert;
        vertex.color = color;

        vertex.position = new Vector3(-lineThickness/2,0);
        vertex.position += new Vector3(cellWidth*point.x,cellHeight*point.y);
        vh.AddVert(vertex);

        vertex.position = new Vector3(lineThickness / 2, 0);
        vertex.position += new Vector3(cellWidth * point.x, cellHeight * point.y);
        vh.AddVert(vertex);

    }
}
