using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceController : MonoBehaviour
{
    Waypoint currentSpace;
    public GameObject board;
    public int defaultMove;

    // Start is called before the first frame update
    void Start()
    {
        defaultMove = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GetCurrentSpace()
    {
        currentSpace = GetTargetSpace(gameObject);
    }

    public Waypoint GetTargetSpace(GameObject target)
    {
        RaycastHit2D hit;
        Waypoint space = null;
        hit = Physics2D.Raycast(target.transform.position, -Vector2.zero);
        if(hit.collider != null)
        {
            space = hit.collider.GetComponent<Waypoint>();
            Debug.Log("Current Tile: " + space.name);
            space.BreadthFirstSearch(defaultMove, Color.green, true);
        }
        else
        {
            Debug.Log("Raycast missed");
        }
        return space;
    }

    IEnumerator Wait(float f)
    {
        yield return new WaitForSeconds(f);
    }

    void OnMouseUp()
    {
        //TODO: ignore click if the mouse is over a UI element
        GetCurrentSpace();
    }
}
