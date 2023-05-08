using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this code makes a certain thing to put the questions and answers
[CreateAssetMenu(fileName = "QuestionsData", menuName = "QuestionsData", order = 1)]
public class QuizDataScriptable : ScriptableObject
{
    public string categoryName;
    public List<Question> questions;
}
