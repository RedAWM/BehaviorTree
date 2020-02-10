using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;

/// <summary>
/// 这个任务脚本的作用就是控制游戏物体到达目标位置
/// </summary>
public class MySeek : Action
{

	public Transform target;

	public float speed;

	public float arraiveDis = 0.1f;

	private float dis;
	/// <summary>
	/// 当进入到这个任务的时候会，会一直调用这个任务，一直到任务结束，返回一个Running状态
	/// 调用频率与Unity保持一致
	// </summary>
	/// <returns></returns>
	public override TaskStatus OnUpdate()
	{
		if (target==null)
		{
			return TaskStatus.Failure;
		}
		transform.LookAt(target.position);
		transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
		dis = Vector3.Distance(transform.position, target.position);
		if (dis<arraiveDis)
		{
			return TaskStatus.Success;
		}
		return TaskStatus.Running;
	}
}
