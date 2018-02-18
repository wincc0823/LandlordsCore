﻿namespace Model
{
	// 充值流水
	public sealed class RechargeRecord : Entity
	{
		// 充值玩家
		public int PlayerNO { get; set; }

		// 充值数量
		public int CardNumber { get; set; }
		
		// 充值时间
		public long Time { get; set; }

		public RechargeRecord(long id): base(id)
		{
		}
	}

	// 保存玩家充值记录, 每个玩家只有一条
	public sealed class Recharge : Entity
	{
		public int CardNumber { get; set; }
		
		public long UpdateTime { get; set; }

		public Recharge(long id): base(id)
		{
		}
	}

	public class HttpResult
	{
		public int code;
		public bool status;
		public string msg = "";
	}

	public static partial class ErrorCode
	{
		public const int Exception = 11000;
		public const int RpcFail = 11002;
        public const int Success = 0;
    }
}