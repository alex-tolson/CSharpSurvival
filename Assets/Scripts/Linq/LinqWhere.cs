using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class LinqWhere : MonoBehaviour
{

    public string[] names = { "tom", "tiffany", "Bartholomew", "dimi", "dimitri", "tom",
        "pete", "cody", "dimi", "harry", "jesse", "patrick", "clause", "pete" };


    void Start()
    {
        var result = names.Where(n => n.Length > 5);

        foreach (var name in result)
        {
            Debug.Log(name);
        }
    }


    void Update()
    {
        
    }
}
