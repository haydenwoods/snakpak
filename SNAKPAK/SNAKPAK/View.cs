// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: View.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from View.proto</summary>
public static partial class ViewReflection {

  #region Descriptor
  /// <summary>File descriptor for View.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ViewReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "CgpWaWV3LnByb3RvIlQKCENvbXB1dGVyEgwKBG5hbWUYASABKAkSEAoIaG9z",
          "dE5hbWUYAiABKAkSDAoEcG9zWBgDIAEoBRIMCgRwb3NZGAQgASgFEgwKBHBv",
          "c1oYBSABKAUidQoEVmlldxIMCgRuYW1lGAEgASgJEhcKCHN1YnZpZXdzGAIg",
          "AygLMgUuVmlldxIcCgljb21wdXRlcnMYAyADKAsyCS5Db21wdXRlchIMCgRw",
          "b3NYGAQgASgFEgwKBHBvc1kYBSABKAUSDAoEcG9zWhgGIAEoBSI2CghMaXN0",
          "aW5ncxIMCgRuYW1lGAEgASgJEhwKCWNvbXB1dGVycxgCIAMoCzIJLkNvbXB1",
          "dGVyYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::Computer), global::Computer.Parser, new[]{ "Name", "HostName", "PosX", "PosY", "PosZ" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::View), global::View.Parser, new[]{ "Name", "Subviews", "Computers", "PosX", "PosY", "PosZ" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::Listings), global::Listings.Parser, new[]{ "Name", "Computers" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class Computer : pb::IMessage<Computer> {
  private static readonly pb::MessageParser<Computer> _parser = new pb::MessageParser<Computer>(() => new Computer());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Computer> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ViewReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Computer() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Computer(Computer other) : this() {
    name_ = other.name_;
    hostName_ = other.hostName_;
    posX_ = other.posX_;
    posY_ = other.posY_;
    posZ_ = other.posZ_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Computer Clone() {
    return new Computer(this);
  }

  /// <summary>Field number for the "name" field.</summary>
  public const int NameFieldNumber = 1;
  private string name_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Name {
    get { return name_; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "hostName" field.</summary>
  public const int HostNameFieldNumber = 2;
  private string hostName_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string HostName {
    get { return hostName_; }
    set {
      hostName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "posX" field.</summary>
  public const int PosXFieldNumber = 3;
  private int posX_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int PosX {
    get { return posX_; }
    set {
      posX_ = value;
    }
  }

  /// <summary>Field number for the "posY" field.</summary>
  public const int PosYFieldNumber = 4;
  private int posY_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int PosY {
    get { return posY_; }
    set {
      posY_ = value;
    }
  }

  /// <summary>Field number for the "posZ" field.</summary>
  public const int PosZFieldNumber = 5;
  private int posZ_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int PosZ {
    get { return posZ_; }
    set {
      posZ_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Computer);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Computer other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Name != other.Name) return false;
    if (HostName != other.HostName) return false;
    if (PosX != other.PosX) return false;
    if (PosY != other.PosY) return false;
    if (PosZ != other.PosZ) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Name.Length != 0) hash ^= Name.GetHashCode();
    if (HostName.Length != 0) hash ^= HostName.GetHashCode();
    if (PosX != 0) hash ^= PosX.GetHashCode();
    if (PosY != 0) hash ^= PosY.GetHashCode();
    if (PosZ != 0) hash ^= PosZ.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Name.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Name);
    }
    if (HostName.Length != 0) {
      output.WriteRawTag(18);
      output.WriteString(HostName);
    }
    if (PosX != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(PosX);
    }
    if (PosY != 0) {
      output.WriteRawTag(32);
      output.WriteInt32(PosY);
    }
    if (PosZ != 0) {
      output.WriteRawTag(40);
      output.WriteInt32(PosZ);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Name.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
    }
    if (HostName.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(HostName);
    }
    if (PosX != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(PosX);
    }
    if (PosY != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(PosY);
    }
    if (PosZ != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(PosZ);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Computer other) {
    if (other == null) {
      return;
    }
    if (other.Name.Length != 0) {
      Name = other.Name;
    }
    if (other.HostName.Length != 0) {
      HostName = other.HostName;
    }
    if (other.PosX != 0) {
      PosX = other.PosX;
    }
    if (other.PosY != 0) {
      PosY = other.PosY;
    }
    if (other.PosZ != 0) {
      PosZ = other.PosZ;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Name = input.ReadString();
          break;
        }
        case 18: {
          HostName = input.ReadString();
          break;
        }
        case 24: {
          PosX = input.ReadInt32();
          break;
        }
        case 32: {
          PosY = input.ReadInt32();
          break;
        }
        case 40: {
          PosZ = input.ReadInt32();
          break;
        }
      }
    }
  }

}

public sealed partial class View : pb::IMessage<View> {
  private static readonly pb::MessageParser<View> _parser = new pb::MessageParser<View>(() => new View());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<View> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ViewReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public View() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public View(View other) : this() {
    name_ = other.name_;
    subviews_ = other.subviews_.Clone();
    computers_ = other.computers_.Clone();
    posX_ = other.posX_;
    posY_ = other.posY_;
    posZ_ = other.posZ_;
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public View Clone() {
    return new View(this);
  }

  /// <summary>Field number for the "name" field.</summary>
  public const int NameFieldNumber = 1;
  private string name_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Name {
    get { return name_; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "subviews" field.</summary>
  public const int SubviewsFieldNumber = 2;
  private static readonly pb::FieldCodec<global::View> _repeated_subviews_codec
      = pb::FieldCodec.ForMessage(18, global::View.Parser);
  private readonly pbc::RepeatedField<global::View> subviews_ = new pbc::RepeatedField<global::View>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::View> Subviews {
    get { return subviews_; }
  }

  /// <summary>Field number for the "computers" field.</summary>
  public const int ComputersFieldNumber = 3;
  private static readonly pb::FieldCodec<global::Computer> _repeated_computers_codec
      = pb::FieldCodec.ForMessage(26, global::Computer.Parser);
  private readonly pbc::RepeatedField<global::Computer> computers_ = new pbc::RepeatedField<global::Computer>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::Computer> Computers {
    get { return computers_; }
  }

  /// <summary>Field number for the "posX" field.</summary>
  public const int PosXFieldNumber = 4;
  private int posX_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int PosX {
    get { return posX_; }
    set {
      posX_ = value;
    }
  }

  /// <summary>Field number for the "posY" field.</summary>
  public const int PosYFieldNumber = 5;
  private int posY_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int PosY {
    get { return posY_; }
    set {
      posY_ = value;
    }
  }

  /// <summary>Field number for the "posZ" field.</summary>
  public const int PosZFieldNumber = 6;
  private int posZ_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int PosZ {
    get { return posZ_; }
    set {
      posZ_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as View);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(View other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Name != other.Name) return false;
    if(!subviews_.Equals(other.subviews_)) return false;
    if(!computers_.Equals(other.computers_)) return false;
    if (PosX != other.PosX) return false;
    if (PosY != other.PosY) return false;
    if (PosZ != other.PosZ) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Name.Length != 0) hash ^= Name.GetHashCode();
    hash ^= subviews_.GetHashCode();
    hash ^= computers_.GetHashCode();
    if (PosX != 0) hash ^= PosX.GetHashCode();
    if (PosY != 0) hash ^= PosY.GetHashCode();
    if (PosZ != 0) hash ^= PosZ.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Name.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Name);
    }
    subviews_.WriteTo(output, _repeated_subviews_codec);
    computers_.WriteTo(output, _repeated_computers_codec);
    if (PosX != 0) {
      output.WriteRawTag(32);
      output.WriteInt32(PosX);
    }
    if (PosY != 0) {
      output.WriteRawTag(40);
      output.WriteInt32(PosY);
    }
    if (PosZ != 0) {
      output.WriteRawTag(48);
      output.WriteInt32(PosZ);
    }
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Name.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
    }
    size += subviews_.CalculateSize(_repeated_subviews_codec);
    size += computers_.CalculateSize(_repeated_computers_codec);
    if (PosX != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(PosX);
    }
    if (PosY != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(PosY);
    }
    if (PosZ != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(PosZ);
    }
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(View other) {
    if (other == null) {
      return;
    }
    if (other.Name.Length != 0) {
      Name = other.Name;
    }
    subviews_.Add(other.subviews_);
    computers_.Add(other.computers_);
    if (other.PosX != 0) {
      PosX = other.PosX;
    }
    if (other.PosY != 0) {
      PosY = other.PosY;
    }
    if (other.PosZ != 0) {
      PosZ = other.PosZ;
    }
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Name = input.ReadString();
          break;
        }
        case 18: {
          subviews_.AddEntriesFrom(input, _repeated_subviews_codec);
          break;
        }
        case 26: {
          computers_.AddEntriesFrom(input, _repeated_computers_codec);
          break;
        }
        case 32: {
          PosX = input.ReadInt32();
          break;
        }
        case 40: {
          PosY = input.ReadInt32();
          break;
        }
        case 48: {
          PosZ = input.ReadInt32();
          break;
        }
      }
    }
  }

}

public sealed partial class Listings : pb::IMessage<Listings> {
  private static readonly pb::MessageParser<Listings> _parser = new pb::MessageParser<Listings>(() => new Listings());
  private pb::UnknownFieldSet _unknownFields;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<Listings> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ViewReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Listings() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Listings(Listings other) : this() {
    name_ = other.name_;
    computers_ = other.computers_.Clone();
    _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public Listings Clone() {
    return new Listings(this);
  }

  /// <summary>Field number for the "name" field.</summary>
  public const int NameFieldNumber = 1;
  private string name_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Name {
    get { return name_; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "computers" field.</summary>
  public const int ComputersFieldNumber = 2;
  private static readonly pb::FieldCodec<global::Computer> _repeated_computers_codec
      = pb::FieldCodec.ForMessage(18, global::Computer.Parser);
  private readonly pbc::RepeatedField<global::Computer> computers_ = new pbc::RepeatedField<global::Computer>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::Computer> Computers {
    get { return computers_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as Listings);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(Listings other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Name != other.Name) return false;
    if(!computers_.Equals(other.computers_)) return false;
    return Equals(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Name.Length != 0) hash ^= Name.GetHashCode();
    hash ^= computers_.GetHashCode();
    if (_unknownFields != null) {
      hash ^= _unknownFields.GetHashCode();
    }
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Name.Length != 0) {
      output.WriteRawTag(10);
      output.WriteString(Name);
    }
    computers_.WriteTo(output, _repeated_computers_codec);
    if (_unknownFields != null) {
      _unknownFields.WriteTo(output);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Name.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
    }
    size += computers_.CalculateSize(_repeated_computers_codec);
    if (_unknownFields != null) {
      size += _unknownFields.CalculateSize();
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(Listings other) {
    if (other == null) {
      return;
    }
    if (other.Name.Length != 0) {
      Name = other.Name;
    }
    computers_.Add(other.computers_);
    _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
          break;
        case 10: {
          Name = input.ReadString();
          break;
        }
        case 18: {
          computers_.AddEntriesFrom(input, _repeated_computers_codec);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
