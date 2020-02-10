using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;

/// <summary>
/// 用来判断目标是否在视野内
/// </summary>
public class MyCanSeeObj : Conditional
{

	public Transform[] targets;//判断是否在视野内的目标
	public float filedOfView = 90;
	public float ViewDis = 7;
//
//	public override TaskStatus OnUpdate()
//	{
//		if (targets==null)
//		{
//			return TaskStatus.Failure;//任务失败
//		}
//
//		foreach (var target in targets)
//		{
//			
//		}
//		
//		
//	}
}
