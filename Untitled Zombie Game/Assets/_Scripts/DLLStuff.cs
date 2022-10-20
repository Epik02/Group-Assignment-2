using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

public class DLLStuff : MonoBehaviour
{
    //[DllImport("GameDLL1.dll")]
    //private static extern IntPtr ReadLevelLayout();

    [DllImport("GameDLL1 1.dll")]
    private static extern int ReturnInt();

    [DllImport("GameDLL1 1.dll")]
    private static extern float ReturnFloat();

    [DllImport("GameDLL1 1.dll")]
    private static extern int AddTwo(int x, int y);

    [DllImport("GameDLL1 1.dll")]
    private static extern int SubtractTwo(int x, int y);

    [DllImport("GameDLL1 1.dll")]
    private static extern float SubtractFloats(float x, float y);

    //[DllImport("GameDLL2.dll")]
    //private static extern void ReturnClassInstance(StringBuilder instance);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ReturnInt call gave: " + ReturnInt());
        Debug.Log("ReturnFloat call gave: " + ReturnFloat());
        Debug.Log("AddTwo call gave: " + AddTwo(2, 4));
        Debug.Log("Subtract Two call gave: " + SubtractTwo(50, 10));

        Debug.Log("Subtract floats call gave: " + SubtractFloats(5.5f, 1.6f));

        //var str = ReadLevelLayout();
        //var strResult = System.Runtime.InteropServices.Marshal.PtrToStringAnsi(str);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
