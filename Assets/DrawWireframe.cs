using UnityEngine;
using System.Collections;
using UnityEditor;
// script activates wireframe (no ideea how)
public class DrawWireframe : MonoBehaviour
{
    void OnPreRender()
    {
        GL.wireframe = true;
      

    }
    void OnPostRender()
    {
        GL.wireframe = false;
    }
   
}


