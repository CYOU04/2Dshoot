using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourScript20251210 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //float[] floats = new float[10];
        List<float> list = new List<float>();
        list.Add(0f);
        list.RemoveAt(0);

        Dictionary<string, GameObject> dic = new Dictionary<string, GameObject>();

        Stack<Vector2> stack = new Stack<Vector2>();
        stack.Push(new Vector2(0f, 0f));
        var v = stack.Pop();

        Queue<Vector3> queue = new Queue<Vector3>();
        queue.Enqueue(v);
        var v2 = queue.Dequeue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}