using System;
using System.Collections;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speed = 5.0f;
    private MeshRenderer _render;
    float h;
    float v;

    // Start is called before the first frame update
    void Start()
    {
        _render = GetComponent<MeshRenderer>();

    }
    private void OnEnable()
    {
        CallbackAction.onEndReached += FinishedWave;
    }
    private void OnDisable()
    {
        CallbackAction.onEndReached -= FinishedWave;
    }

    private void Update()
    {
        MoveCubes();
    } 

    private void MoveCubes()
    {
         h = Input.GetAxis("Horizontal");
         v = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(h, 0, v);
        Vector3 velocity = direction * speed;

        transform.Translate(velocity * Time.deltaTime);
    }

    public void FinishedWave(Cube instance)
    {
        if (this==instance)
        {
            Debug.Log("I caused this trouble..." + transform.name);
            return;
        }

        StartCoroutine(ColorChange (() =>
        { 
            _render.material.color = Color.black;

        }));

    }

    IEnumerator ColorChange(Action onComplete = null)
    {

        Color newColor = new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
        _render.material.color = newColor;
        Debug.Log("Changing to random color");
        yield return new WaitForSeconds(3.0f);

        if (onComplete != null)
        {
            onComplete();
        }


    }
}
