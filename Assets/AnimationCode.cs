using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Threading;

public class AnimationCode : MonoBehaviour
{

    public GameObject[] Body;
    List<string> lines;
    int counter = 0;

    void Start()
    {
        // ��ȡMotionFile.txt�Ķ��������ļ�
        lines = System.IO.File.ReadLines("Assets/MotionFile.txt").ToList();
    }

    void Update()
    {
        string[] points = lines[counter].Split(',');

        // ѭ��������ÿһ��Sphere��
        for (int i = 0; i <= 32; i++)
        {
            float x = float.Parse(points[0 + (i * 3)]) / 100;
            float y = float.Parse(points[1 + (i * 3)]) / 100;
            float z = float.Parse(points[2 + (i * 3)]) / 300;
            Body[i].transform.localPosition = new Vector3(x, y, z);
        }

        counter += 1;
        if (counter == lines.Count) { counter = 0; }
        Thread.Sleep(30);
    }
}