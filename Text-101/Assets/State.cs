using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

//Creamos un menu con el nombre de la clase. Así aparece en el menú de assets de Unity para ser creado 
[CreateAssetMenu(menuName = "State")]
//Cambiamos MonoBehaviour a ScriptableObject en esta clase
public class State : ScriptableObject
{
    //SerializeField permite que aparezca como recurso
    //TextArea() crea un area de texto en la interfaz de Unity del Scriptable Obj
    [TextArea(10, 14)] [SerializeField] string storyText;

    //Declaramos una variable llamada nextStates, de tipo State Array y la serializamos para usarla en la UI. Esto permite que arrastremos el state en la UI y no tengamos que determinarlo en el código
    [SerializeField] State[] nextStates;

    // retorna el valor actual de storyText
    public string GetStateStory()
    {
        return storyText;
    }

    //Creamos el método público de tipo StateArray llamado GetNextStates
    public State[] GetNextStates()
    {
        return nextStates;        
    }

}
