// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/Student.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcService {
  public static partial class Student
  {
    static readonly string __ServiceName = "Student";

    static readonly grpc::Marshaller<global::GrpcService.StudentLookUp> __Marshaller_StudentLookUp = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.StudentLookUp.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.StudentInfo> __Marshaller_StudentInfo = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.StudentInfo.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::GrpcService.StudentAllLoopUp> __Marshaller_StudentAllLoopUp = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::GrpcService.StudentAllLoopUp.Parser.ParseFrom);

    static readonly grpc::Method<global::GrpcService.StudentLookUp, global::GrpcService.StudentInfo> __Method_GetStudent = new grpc::Method<global::GrpcService.StudentLookUp, global::GrpcService.StudentInfo>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetStudent",
        __Marshaller_StudentLookUp,
        __Marshaller_StudentInfo);

    static readonly grpc::Method<global::GrpcService.StudentAllLoopUp, global::GrpcService.StudentInfo> __Method_GetAllStudents = new grpc::Method<global::GrpcService.StudentAllLoopUp, global::GrpcService.StudentInfo>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetAllStudents",
        __Marshaller_StudentAllLoopUp,
        __Marshaller_StudentInfo);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcService.StudentReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Student</summary>
    [grpc::BindServiceMethod(typeof(Student), "BindService")]
    public abstract partial class StudentBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcService.StudentInfo> GetStudent(global::GrpcService.StudentLookUp request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task GetAllStudents(global::GrpcService.StudentAllLoopUp request, grpc::IServerStreamWriter<global::GrpcService.StudentInfo> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(StudentBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetStudent, serviceImpl.GetStudent)
          .AddMethod(__Method_GetAllStudents, serviceImpl.GetAllStudents).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, StudentBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetStudent, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcService.StudentLookUp, global::GrpcService.StudentInfo>(serviceImpl.GetStudent));
      serviceBinder.AddMethod(__Method_GetAllStudents, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::GrpcService.StudentAllLoopUp, global::GrpcService.StudentInfo>(serviceImpl.GetAllStudents));
    }

  }
}
#endregion
