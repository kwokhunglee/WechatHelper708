using ProtoBuf;
using System;
using System.ComponentModel;

namespace micromsg
{
	[ProtoContract(Name = "ScanStreetViewResponse")]
	[Serializable]
	public class ScanStreetViewResponse : IExtensible
	{
		private BaseResponse _BaseResponse;

		private uint _Type;

		private string _DescriptionXML = "";

		private IExtension extensionObject;

		[ProtoMember(1, IsRequired = true, Name = "BaseResponse", DataFormat = DataFormat.Default)]
		public BaseResponse BaseResponse
		{
			get
			{
				return this._BaseResponse;
			}
			set
			{
				this._BaseResponse = value;
			}
		}

		[ProtoMember(2, IsRequired = true, Name = "Type", DataFormat = DataFormat.TwosComplement)]
		public uint Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				this._Type = value;
			}
		}

		[ProtoMember(3, IsRequired = false, Name = "DescriptionXML", DataFormat = DataFormat.Default), DefaultValue("")]
		public string DescriptionXML
		{
			get
			{
				return this._DescriptionXML;
			}
			set
			{
				this._DescriptionXML = value;
			}
		}

		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}
	}
}
