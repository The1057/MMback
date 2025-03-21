using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class graphSetup : MonoBehaviour
{
    public GameObject graphDisplay;
    public GameObject grid;
    public GameObject line;

    public GraphCanvasScript gridScript;
    public LineScript lineScript;

    public storeScript sc;


    public Vector2Int gridSize = new Vector2Int(12, 12);
    public List<Vector2> points;
    public float gridThickness = 0.75f;
    public float lineThickness = 2.5f;
    public Color lineColor = Color.red;

    void Start()
    {
        grid.transform.position = this.transform.position;        
        line.transform.position = this.transform.position;

        gridScript.gridSize = this.gridSize;
        gridScript.thickness = this.gridThickness;
        lineScript.gridSize = this.gridSize;
        lineScript.lineThickness = this.lineThickness;
        lineScript.points = this.points;

    }

    private void Update()
    {
        if (grid != null)
        {
            gridScript.gridSize = this.gridSize;
            gridScript.thickness = this.gridThickness;
            lineScript.gridSize = this.gridSize;
            lineScript.lineThickness = this.lineThickness;
            lineScript.points = this.points;
            lineScript.color = lineColor;
        }
    }

    public void setup()
    {
        Canvas canvas = GameObject.FindFirstObjectByType<Canvas>();
        sc = GameObject.FindFirstObjectByType<storeScript>();

        // set graph arguments here \/

        this.lineColor = Color.black;
        this.points = sc.points4GraphFinal;

        // set graph arguments here /\


        Instantiate(graphDisplay,canvas.transform);
    }
}
