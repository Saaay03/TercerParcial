using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LessonContainer : MonoBehaviour
{
//Define el número de lecciones, la leccion actual y si todas las lecciones se realizaron
    [Header ("GameObject Configuration")]
    public int Lection = 0;
    public int CurrentLession = 0;
    public int TotalLessions = 0;
    public bool AreAllLessonsComplete = false;

//Configura el titulo y el texto que contiene cada leccion
    [Header("UI Configuration")]
    public TMP_Text StageTitle;
    public TMP_Text LessonStage;

//Contenedor de las lecciones
    [Header("External GameObject Configuration")]
    public GameObject lessonContainer;

//Administra las lecciones a través de un scriptable object
    [Header("Lesson Data")]
    public ScriptableObject lessonData;
    public string LessonName;

    [Header("Credits Container")]
    public GameObject credits;

    // Start is called before the first frame update
    void Start()
    {
      if (lessonContainer !=null) 
        {
//Actualiza la interfaz del usuario
            OnUpdateUI();
        }
      else
        {
//Emite una advertencia de que hay un GameObject nulo
            Debug.LogWarning("GameObject Nulo, revisa las variables de tipo GameObject lessonContainer " + name);
        }
    }

//Actualiza las lecciones en la interfaz
    public void OnUpdateUI()
    {
        if (StageTitle != null || LessonStage !=null) 
        {
//Actualiza el texto de las lecciones
            StageTitle.text = "Leccion " + Lection;
            LessonStage.text = "Leccion " + CurrentLession + " de " + TotalLessions;
        }
        else
        {
//Si no se cumple el codigo, se manda un aviso de que no se han asignad los objetos en sus slots correspondientes
            Debug.LogWarning("GameObject Nulo, revisa las variables de tipo TMP_Text");
        }
    }

//Este modo activa/desactiva la ventana de lessonContainer
    public void EnableWindow()
    {
        OnUpdateUI();

        if (lessonContainer.activeSelf)
        {
//Desactiva el objeto si está activo
            lessonContainer.SetActive(false);
        }
        else
        {
            MainScript.instance.SetSelectedLesson(LessonName);
//Activa el objeto si está desactivado
            lessonContainer.SetActive(true);
        }
    } 
//Activa la pantalla de creditos
    public void OnEnableCredits()
    {
        if (credits.activeSelf)
        {
            credits.SetActive(false);
        }
        else
        {
            credits.SetActive(true);
        }
    }
}
