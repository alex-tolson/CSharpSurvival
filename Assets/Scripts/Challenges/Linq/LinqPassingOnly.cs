using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.VisualScripting;

public class LinqPassingOnly : MonoBehaviour
{
    public List<int> grades;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        { int randomNum = Random.Range(1, 101);
            grades.Add(randomNum);
            Debug.Log("Adding quiz grade: " + randomNum);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var result = grades.Where(grades => grades > 69).OrderByDescending(grades => grades).Reverse();
            foreach (var passingGrade in result)
            {
                Debug.Log("passing grade: " + passingGrade);
            }
        }
        if(Input.GetKeyDown(KeyCode.C))
        {
            grades.Clear();
            Debug.Log("Clearing");
        }
    }
}
