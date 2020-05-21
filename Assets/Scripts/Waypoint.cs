using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoint : MonoBehaviour
{
    public Waypoint[] adjacentWaypoints;
    int numExistingPieces;
    private bool visited;

    // Start is called before the first frame update
    void Start()
    {
        //make PolygonCollider2D visible
        int pointCount = 0;
        pointCount = this.GetComponent<PolygonCollider2D>().GetTotalPointCount();
        MeshFilter mf = GetComponent<MeshFilter>();
        Mesh mesh = new Mesh();
        Vector2[] points = this.GetComponent<PolygonCollider2D>().points;
        Vector3[] vertices = new Vector3[pointCount];
        Vector2[] uv = new Vector2[pointCount];
        for(int ind = 0; ind < pointCount; ind++){
            Vector2 actual = points[ind];
            vertices[ind] = new Vector3(actual.x, actual.y, 0);
            uv[ind] = actual;
        }
        Triangulator tr = new Triangulator(points);
        int [] triangles = tr.Triangulate();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uv;
        mf.mesh = mesh;
        //end visible PolygonCollider2D

        this.GetComponent<MeshRenderer>().materials[0].color = Color.red;
        visited = false;
    }

    // Update is called once per frame
    void Update()
    {        
    }

    void OnMouseDown()
    {
        if(visited)
        {
            //Move Pieces
            BreadthFirstSearch(3, Color.red, false);    //after moving pieces
            StartCoroutine(Wait(0.25f));
            this.SetColor(Color.blue);
        }
        else
        {
            Debug.Log("Invalid move, please try again");
        }
    }

    public void BreadthFirstSearch(int remainingMovement, Color c, bool v)
    {
        if(remainingMovement >= 0)
        {
            this.SetColor(c);
            this.visited = v;
            for(int ind = 0; ind < adjacentWaypoints.Length; ++ind)
            {
                adjacentWaypoints[ind].BreadthFirstSearch(remainingMovement - 1, c, v);
            }
        }
        else
        {
            return;
        }
    }

    IEnumerator Wait(float f)
    {
        yield return new WaitForSeconds(f);
        visited = false;
    }

    void SetColor(Color c)
    {
        this.GetComponent<MeshRenderer>().materials[0].color = c;
        //StartCoroutine(Wait());
    }
}
