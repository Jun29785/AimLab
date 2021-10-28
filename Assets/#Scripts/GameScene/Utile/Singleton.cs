using System;
using UnityEngine;

public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
	private static T instance = null;
	private static object syncObject = new object();

	public static T Instance
	{
		get
		{
			// 인스턴스가 비어있다면
			if (instance == null)
			{
				lock (syncObject)
				{
					// 씬에서 인스턴스를 찾는다.
					instance = FindObjectOfType<T>();
					// 인스턴스를 못 찾았다면
					if (instance == null)
					{
						// 빈 게임오브젝트를 생성하고, 게임 오브젝트의 이름을 t타입으로
						GameObject obj = new GameObject(typeof(T).Name);
						// 빈 게임오브젝트에 T타입 컴포넌트를 붙여준다.
						instance = obj.AddComponent<T>();
					}
				}
			}
			return instance;
		}
	}

	// Awake가 호출됬다는건 씬에 T타입 클래스가 존재
	protected virtual void Awake()
	{
		if (instance == null)
		{
			instance = this as T;
		}
	}
}
