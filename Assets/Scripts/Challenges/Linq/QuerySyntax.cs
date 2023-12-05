using System.Linq;
using UnityEngine;

public class QuerySyntax : MonoBehaviour
{
    //Specify: What's the data source?
    int[] grades = new int[] { 97, 92, 95, 78, 36, 54, 69 };

    void Start()
    {
        //Method Syntax:::

        var gradeQuery = grades.Where(grade => grade > 80);

        foreach (var grade in gradeQuery)
        {
            Debug.Log("Grade: " + grade);
        }
    }
}


//}
////Define the query expression.
//IEnumerable<int> gradeQuery =
//    from grade in grades // Each element in the grades array
//    where grade > 80     //Filter the values that are over 80
//    select grade;        //select the element value

////Execute:: the query //

//foreach (int i in gradeQuery)
//{
//    Debug.Log(i);  //log to console query result
//}
////}
