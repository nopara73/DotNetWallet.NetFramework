﻿using DotNetWallet.NetFramework.KeyManagement;
using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetWallet.NetFramework
{
	public static class FakeData
	{
		public static class FakeSafe
		{
			private static List<BitcoinAddress> fakeSafeAddresses = new List<BitcoinAddress>();
			static FakeSafe()
			{
				var addresses = new List<string>
				{
					"1CCXoPdEpWr2KZ1xJz5QHyUR3Nn8yFeCut",
					"1P2GWrCNJorPrHJdkHdtkAdEdUuWQq8uxg",
					"12D6kUKJm4jxYwRkMBavJepdznJToBKg9J",
					new Key().PubKey.GetAddress(Network).ToString(),
					"1Jq67oPBoDcDAmNWVpv4MVFLz1RHkcgi9N",
					"1LuMj4J43iPp86ZwfnNTtNAKf9bpAqiNwh",
					"1gNT1YgsbaEEV2cUikcWL3puZHvwKs9ae",
					new Key().PubKey.GetAddress(Network).ToString(),
					"1JvaeimvLV5B7yHNHBPUfBy1SM4H6rFazU",
					"1Jq8iGGT1idaK9z8H7mrYPynjh9LozHnSH",
					"1AcAxGyuMrgEga2daotAPWTYazt965o9rG",
					"1b2ryTRhoCDiCDndLk7LjsZRs8t2RSkET",
					new Key().PubKey.GetAddress(Network).ToString(),
					"17tA7cXneTB8do1kWsYLbX6KUrkj99cGnL",
					"16kj374w6nvvSjTKdU1k7axP9bFghTNsfc",
					"1BSdeyWS627UMNHuwSv2diKjJFGrY6Hteo",
					new Key().PubKey.GetAddress(Network).ToString(),
					"1Q3ZNxmXRjMFA2W3yiyujGNsfjdcoATemp",
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString(),
					new Key().PubKey.GetAddress(Network).ToString()
				};
				HashSet<string> uniqueAddresses = new HashSet<string>();
				foreach (var addr in addresses)
					uniqueAddresses.Add(addr);
				foreach (var addr in uniqueAddresses)
					fakeSafeAddresses.Add(BitcoinAddress.Create(addr));
			}
			public static Network Network => Network.Main;
			public static BitcoinAddress GetAddress(int index)
			{
				return fakeSafeAddresses[index];
			}
			public static HashSet<BitcoinAddress> GetFirstNAddresses(int addressCount)
			{
				var addresses = new HashSet<BitcoinAddress>();
				for (var i = 0; i < addressCount; i++)
				{
					addresses.Add(GetAddress(i));
				}
				return addresses;
			}
		}
	}
}
