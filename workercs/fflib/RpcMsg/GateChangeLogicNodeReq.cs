/**
 * Autogenerated by Thrift Compiler (0.9.1)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;


#if !SILVERLIGHT
[Serializable]
#endif
public partial class GateChangeLogicNodeReq : TBase
{
  private long _sessionId;
  private string _allocWorker;
  private byte[] _extraData;

  public long SessionId
  {
    get
    {
      return _sessionId;
    }
    set
    {
      __isset.sessionId = true;
      this._sessionId = value;
    }
  }

  public string AllocWorker
  {
    get
    {
      return _allocWorker;
    }
    set
    {
      __isset.allocWorker = true;
      this._allocWorker = value;
    }
  }

  public byte[] ExtraData
  {
    get
    {
      return _extraData;
    }
    set
    {
      __isset.extraData = true;
      this._extraData = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool sessionId;
    public bool allocWorker;
    public bool extraData;
  }

  public GateChangeLogicNodeReq() {
    this._sessionId = 0;
    this.__isset.sessionId = true;
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
          if (field.Type == TType.I64) {
            SessionId = iprot.ReadI64();
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 2:
          if (field.Type == TType.String) {
            AllocWorker = iprot.ReadString();
          } else { 
            TProtocolUtil.Skip(iprot, field.Type);
          }
          break;
        case 3:
          if (field.Type == TType.String) {
            ExtraData = iprot.ReadBinary();
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
    TStruct struc = new TStruct("GateChangeLogicNodeReq");
    oprot.WriteStructBegin(struc);
    TField field = new TField();
    if (__isset.sessionId) {
      field.Name = "sessionId";
      field.Type = TType.I64;
      field.ID = 1;
      oprot.WriteFieldBegin(field);
      oprot.WriteI64(SessionId);
      oprot.WriteFieldEnd();
    }
    if (AllocWorker != null && __isset.allocWorker) {
      field.Name = "allocWorker";
      field.Type = TType.String;
      field.ID = 2;
      oprot.WriteFieldBegin(field);
      oprot.WriteString(AllocWorker);
      oprot.WriteFieldEnd();
    }
    if (ExtraData != null && __isset.extraData) {
      field.Name = "extraData";
      field.Type = TType.String;
      field.ID = 3;
      oprot.WriteFieldBegin(field);
      oprot.WriteBinary(ExtraData);
      oprot.WriteFieldEnd();
    }
    oprot.WriteFieldStop();
    oprot.WriteStructEnd();
  }

  public override string ToString() {
    StringBuilder sb = new StringBuilder("GateChangeLogicNodeReq(");
    sb.Append("SessionId: ");
    sb.Append(SessionId);
    sb.Append(",AllocWorker: ");
    sb.Append(AllocWorker);
    sb.Append(",ExtraData: ");
    sb.Append(ExtraData);
    sb.Append(")");
    return sb.ToString();
  }

}

