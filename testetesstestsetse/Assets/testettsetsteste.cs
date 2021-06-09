using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CoordinateSystems;

public class testettsetsteste : MonoBehaviour
{
    public GameObject obj;
    CoordinateSystem a;
    CoordinateSystem c;
    void Start()
    {
        //this.transform.rotation;
        a = new CoordinateSystem(new Vector(this.transform.position.x, this.transform.position.y, this.transform.position.z), new Basis(new UnitVector(-1,0,0), new UnitVector(0,-1,0), new UnitVector(0,0,-1)), new Vector(0,0,0));
        this.transform.forward = new Vector3(-1,0,0);
        c = new CoordinateSystem(new Vector(obj.transform.position.x, obj.transform.position.y, obj.transform.position.z), new Basis(), new Vector(0,0,0));
        Debug.Log(c.ConvertTo(a).ToString());
        a.TurnTo(c.ConvertTo(a));
        Debug.Log(c.ConvertTo(a).ToString());
        this.transform.forward = new Vector3((float)a.Basis.I.X, (float)a.Basis.I.Y, (float)a.Basis.I.Z);
    }

    void Update()
    {
        
    }
}
