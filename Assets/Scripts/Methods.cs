using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Methods : MonoBehaviour
{
    public static List<T> CreateList<T>(int capacity) => Enumerable.Repeat(default(T), capacity).ToList();  /*Da rivedere il significato di questa riga di codice*/

    public static void UpgradeCheck<T>(ref List<T> list, int length) where T : new()  /*Da rivedere il significato di questa riga di codice*/
    {
		try
		{
			if (list.Count == null) list = CreateList<T>(length);  //Check if the list is empty
			while(list.Count < length) list.Add(new T());  //If the list is minor than the length add a brand new object
		}
		catch
		{
			list = CreateList<T>(length);  //It will create a new list if it fail
		}
    }
}
