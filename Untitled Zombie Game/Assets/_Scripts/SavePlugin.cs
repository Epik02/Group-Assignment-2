using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class SavePlugin : MonoBehaviour
{
    [DllImport("Plugin")]
    private static extern int GetID();

    [DllImport("Plugin")]
    private static extern void SetID(int id);

    [DllImport("Plugin")]
    private static extern Vector3 GetPosition();

    [DllImport("Plugin")]
    private static extern void SetPosition(float x, float y, float z);

    [DllImport("Plugin")]
    private static extern void SaveToFile(int id, float x, float y, float z);

    [DllImport("Plugin")]
    private static extern void StartWriting(string fileName);

    [DllImport("Plugin")]
    private static extern void EndWriting();

    PlayerAction inputAction;
    public Health ph;

    string m_Path;
    string fn;
    public GameObject myobj;
    public ScoreManager myscore;

    // Start is called before the first frame update
    void Start()
    {
        //inputAction = PlayerInputController.controller.inputAction;

        // inputAction.Editor.Save.performed += cntxt => SaveItems();

        m_Path = Application.dataPath;
        fn = m_Path + "/save.txt";
        //SaveItems();
        Debug.Log(fn);
    }

    public void SaveItems()
    {
        StartWriting(fn);

        SaveToFile(0, myscore.score, myscore.score, myscore.score);
        EndWriting();
    }

    // Update is called once per frame
    void Update()
    {
        //if (ph.currentHealth <= 0)
        //{
        //    SaveItems();
        //}
    }
}
