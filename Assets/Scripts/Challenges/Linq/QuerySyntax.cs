using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class QuerySyntax : MonoBehaviour
{
    //Specify: What's the data source?
    int[] grades = new int[] { 97, 92, 95, 78, 36, 54, 69 };

    void Start()
    {
        //Define the query expression.
        IEnumerable<int> gradeQuery =
            from grade in grades // Each element in the grades array
            where grade > 80     //Filter the values that are over 80
            select grade;        //select the element value

        //Execute:: the query //

        foreach (int i in gradeQuery)
        {
            Debug.Log(i);  //log to console query result
        }
    }
}

        ////Method Syntax:::
        //foreach(var grade in gradeQuery)
        //{
        //    Debug.Log("Grade: " + grade);
        //}
    //}

//}
