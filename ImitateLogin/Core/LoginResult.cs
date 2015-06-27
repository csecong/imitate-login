/**
 * Autogenerated by Thrift Compiler (0.8.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;

namespace ImitateLogin
{

	[Serializable]
	public partial class LoginResult : TBase
	{
		private ResultType _Result;
		private string _Msg;
		private Dictionary<string, string> _Cookies;

		public ResultType Result
		{
			get
			{
				return _Result;
			}
			set
			{
				__isset.Result = true;
				this._Result = value;
			}
		}

		public string Msg
		{
			get
			{
				return _Msg;
			}
			set
			{
				__isset.Msg = true;
				this._Msg = value;
			}
		}

		public Dictionary<string, string> Cookies
		{
			get
			{
				return _Cookies;
			}
			set
			{
				__isset.Cookies = true;
				this._Cookies = value;
			}
		}


		public Isset __isset;
		[Serializable]
		public struct Isset {
			public bool Result;
			public bool Msg;
			public bool Cookies;
		}

		public LoginResult() {
			this._Msg = "";
		}

		public void Read (TProtocol iprot)
		{
			TField field;
			iprot.ReadStructBegin();
			while (true)
			{
				field = iprot.ReadFieldBegin();
				if (field.Type == TType.Stop) { 
					break;
				}
				switch (field.ID)
				{
				case 1:
					if (field.Type == TType.I32) {
						Result = (ResultType)iprot.ReadI32();
					} else { 
						TProtocolUtil.Skip(iprot, field.Type);
					}
					break;
				case 2:
					if (field.Type == TType.String) {
						Msg = iprot.ReadString();
					} else { 
						TProtocolUtil.Skip(iprot, field.Type);
					}
					break;
				case 3:
					if (field.Type == TType.Map) {
						{
							Cookies = new Dictionary<string, string>();
							TMap _map0 = iprot.ReadMapBegin();
							for( int _i1 = 0; _i1 < _map0.Count; ++_i1)
							{
								string _key2;
								string _val3;
								_key2 = iprot.ReadString();
								_val3 = iprot.ReadString();
								Cookies[_key2] = _val3;
							}
							iprot.ReadMapEnd();
						}
					} else { 
						TProtocolUtil.Skip(iprot, field.Type);
					}
					break;
				default: 
					TProtocolUtil.Skip(iprot, field.Type);
					break;
				}
				iprot.ReadFieldEnd();
			}
			iprot.ReadStructEnd();
		}

		public void Write(TProtocol oprot) {
			TStruct struc = new TStruct("LoginResult");
			oprot.WriteStructBegin(struc);
			TField field = new TField();
			if (__isset.Result) {
				field.Name = "Result";
				field.Type = TType.I32;
				field.ID = 1;
				oprot.WriteFieldBegin(field);
				oprot.WriteI32((int)Result);
				oprot.WriteFieldEnd();
			}
			if (Msg != null && __isset.Msg) {
				field.Name = "Msg";
				field.Type = TType.String;
				field.ID = 2;
				oprot.WriteFieldBegin(field);
				oprot.WriteString(Msg);
				oprot.WriteFieldEnd();
			}
			if (Cookies != null && __isset.Cookies) {
				field.Name = "Cookies";
				field.Type = TType.Map;
				field.ID = 3;
				oprot.WriteFieldBegin(field);
				{
					oprot.WriteMapBegin(new TMap(TType.String, TType.String, Cookies.Count));
					foreach (string _iter4 in Cookies.Keys)
					{
						oprot.WriteString(_iter4);
						oprot.WriteString(Cookies[_iter4]);
					}
					oprot.WriteMapEnd();
				}
				oprot.WriteFieldEnd();
			}
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}

		public override string ToString() {
			StringBuilder sb = new StringBuilder("LoginResult(");
			sb.Append("Result: ");
			sb.Append(Result);
			sb.Append(",Msg: ");
			sb.Append(Msg);
			sb.Append(",Cookies: ");
			sb.Append(Cookies);
			sb.Append(")");
			return sb.ToString();
		}

	}

}
