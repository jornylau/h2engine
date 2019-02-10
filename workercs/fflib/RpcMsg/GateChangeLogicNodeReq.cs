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

namespace ff
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class GateChangeLogicNodeReq : TBase
  {
    private long _session_id;
    private string _alloc_worker;
    private string _cur_group_name;
    private string _dest_group_name;
    private string _extra_data;

    public long Session_id
    {
      get
      {
        return _session_id;
      }
      set
      {
        __isset.session_id = true;
        this._session_id = value;
      }
    }

    public string Alloc_worker
    {
      get
      {
        return _alloc_worker;
      }
      set
      {
        __isset.alloc_worker = true;
        this._alloc_worker = value;
      }
    }

    public string Cur_group_name
    {
      get
      {
        return _cur_group_name;
      }
      set
      {
        __isset.cur_group_name = true;
        this._cur_group_name = value;
      }
    }

    public string Dest_group_name
    {
      get
      {
        return _dest_group_name;
      }
      set
      {
        __isset.dest_group_name = true;
        this._dest_group_name = value;
      }
    }

    public string Extra_data
    {
      get
      {
        return _extra_data;
      }
      set
      {
        __isset.extra_data = true;
        this._extra_data = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool session_id;
      public bool alloc_worker;
      public bool cur_group_name;
      public bool dest_group_name;
      public bool extra_data;
    }

    public GateChangeLogicNodeReq() {
      this._session_id = 0;
      this.__isset.session_id = true;
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
              Session_id = iprot.ReadI64();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Alloc_worker = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Cur_group_name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              Dest_group_name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              Extra_data = iprot.ReadString();
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
      if (__isset.session_id) {
        field.Name = "session_id";
        field.Type = TType.I64;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(Session_id);
        oprot.WriteFieldEnd();
      }
      if (Alloc_worker != null && __isset.alloc_worker) {
        field.Name = "alloc_worker";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Alloc_worker);
        oprot.WriteFieldEnd();
      }
      if (Cur_group_name != null && __isset.cur_group_name) {
        field.Name = "cur_group_name";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Cur_group_name);
        oprot.WriteFieldEnd();
      }
      if (Dest_group_name != null && __isset.dest_group_name) {
        field.Name = "dest_group_name";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Dest_group_name);
        oprot.WriteFieldEnd();
      }
      if (Extra_data != null && __isset.extra_data) {
        field.Name = "extra_data";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Extra_data);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("GateChangeLogicNodeReq(");
      sb.Append("Session_id: ");
      sb.Append(Session_id);
      sb.Append(",Alloc_worker: ");
      sb.Append(Alloc_worker);
      sb.Append(",Cur_group_name: ");
      sb.Append(Cur_group_name);
      sb.Append(",Dest_group_name: ");
      sb.Append(Dest_group_name);
      sb.Append(",Extra_data: ");
      sb.Append(Extra_data);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
